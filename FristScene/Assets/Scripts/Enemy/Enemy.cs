using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    enum EnemyState
    {
        Idle,
        Patrol,
        Chase,
        Attack
    }
    private EnemyState state = EnemyState.Patrol;
    public Transform[] waypoints;
    int waypointIndex = 0;
    public float waitTimer = 0;
    public float fieldOfView = 60f;
    public float idleTime = 2f;
    private Transform player;
    public float lostRange = 8f;
    public float detectRange = 5f;
    public float attackRanfe = 1.5f;
    public int hp = 5;
    public int maxHp = 5;
    public EnemySpawner spawner;
    public GameObject coinPrefab;
    public int coinDropcount = 2;
    private Animator animator;
    public void Die()
    {
        hp = hp - 1;
        if (hp <= 0)
        {
            spawner.RemoveEnemy(this);
            while (coinDropcount > 0)
            {
                Vector2 circle = Random.insideUnitCircle;
                Vector3 pos = transform.position + new Vector3(circle.x, 0.5f, circle.y);
                Instantiate(coinPrefab, pos, Quaternion.identity);
                coinDropcount--;
            }
            Destroy(gameObject);
        }
        AudioManager.Instance?.PlayHit();
    }
    //巡逻算法
    public float patrolSpeed = 1.5f;
    public float patrolDistance = 3f;
    private Vector3 startPosition;//出生点
    private Vector3 patrolTarget;//目标点
    void PatrolBehavior()
    {
        transform.position = Vector3.MoveTowards(transform.position, patrolTarget, patrolSpeed * Time.deltaTime);
        transform.LookAt(patrolTarget);
        if (Vector3.Distance(transform.position, patrolTarget) < 0.2)
        {
            waitTimer = idleTime;
            state = EnemyState.Idle;
        }
    }
    void IdleBehavior()
    {
        waitTimer -= Time.deltaTime;
        if (waitTimer <= 0)
        {
            waypointIndex++;
            if (waypointIndex >= waypoints.Length) waypointIndex = 0;
            patrolTarget = waypoints[waypointIndex].position;
            state = EnemyState.Patrol;
        }
    }
    //追击算法
    public float chaseSpeed_F = 4f;
    public float chaseSpeed_s = 1f;
    private float distance;
    public float chaseSpeed;
    void ChaseBehavior()
    {
        Vector3 target = player.position;
        target.y = transform.position.y;
        float p = (lostRange - distance) / (lostRange - attackRanfe);
        p = Mathf.Clamp01(p);
        chaseSpeed = Mathf.Lerp(chaseSpeed_s, chaseSpeed_F, p);
        transform.position = Vector3.MoveTowards(transform.position, target, chaseSpeed * Time.deltaTime);
        transform.LookAt(player);
    }
    //攻击算法
    public int attackATK = 10;
    public float attackInterval = 1f;//攻击间隔
    private float attackTimer = 0f;
    private PlayerHealth playerHealth;
    void AttackBehavior()
    {
        transform.LookAt(player);
        attackTimer -= Time.deltaTime;
        if (attackTimer <= 0)
        {
            playerHealth.TakeDamage(attackATK);
            attackTimer = attackInterval;
        }
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        startPosition = transform.position;
        patrolTarget = waypoints[waypointIndex].position;
        playerHealth = player.GetComponent<PlayerHealth>();
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        if (GameManager.Instance.state != GameState.Playing) return;
        Vector3 dir = player.position - transform.position;
        dir.y = 0;
        dir.Normalize();
        float angle = Vector3.Angle(transform.forward, dir);
        distance = Vector3.Distance(transform.position, player.position);
        if (distance < attackRanfe) state = EnemyState.Attack;
        else if (state == EnemyState.Attack && distance > detectRange) state = EnemyState.Chase;
        else if (distance < detectRange && angle < fieldOfView) state = EnemyState.Chase;
        else if (state == EnemyState.Chase && distance > lostRange)
        {
            hp = maxHp;
            state = EnemyState.Patrol;
        }
        else { }
        switch (state)
        {
            case EnemyState.Patrol:
                animator?.SetFloat("Speed", 1f);
                animator?.SetFloat("RunSpeed", patrolSpeed / 4f);
                PatrolBehavior();
                break;
            case EnemyState.Chase:
                animator?.SetFloat("Speed", 1f);
                animator?.SetFloat("RunSpeed", chaseSpeed / 4f);
                ChaseBehavior();
                break;
            case EnemyState.Attack:
                animator?.SetFloat("Speed", 0f);
                AttackBehavior();
                break;
            case EnemyState.Idle:
                animator?.SetFloat("Speed", 0f);
                IdleBehavior();
                break;
        }
    }
    void OnDrawGizmos()
    {
        if (waypoints == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRange);

        Gizmos.color = Color.cyan;
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (i < waypoints.Length - 1)
            {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }
            else
                Gizmos.DrawLine(waypoints[i].position, waypoints[0].position);
        }

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * detectRange);
        Gizmos.DrawRay(transform.position, Quaternion.Euler(0, -fieldOfView, 0) * transform.forward * detectRange);
        Gizmos.DrawRay(transform.position, Quaternion.Euler(0, fieldOfView, 0) * transform.forward * detectRange);
    }
}
