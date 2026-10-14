using UnityEngine;

public class Enemy : MonoBehaviour
{
    enum EnemyState
    {
        Patrol,
        Chase,
        Attack
    }
    private EnemyState state = EnemyState.Patrol;
    private Transform player;
    public float detectRange = 5f;
    public float attackRanfe = 1.5f;
    public int hp = 1;
    public EnemySpawner spawner;
    public void Die()
    {
        hp = hp - 1;
        if(hp <= 0)
        {
            spawner.RemoveEnemy(this);
            Destroy(gameObject);
        }
        AudioManager.Instance?.PlayHit();
    }
    //巡逻算法
    public float patrolSpeed = 1.5f;
    public float patrolDistance = 3f;
    private Vector3 startPosition;//出生点
    private Vector3 patrolPointA;//出生点左侧
    private Vector3 patrolPointB;//出生点右侧
    private Vector3 patrolTarget;//目标点
    void PatrolBehavior()
    {
        Debug.Log("巡逻中");
        transform.position = Vector3.MoveTowards(transform.position,patrolTarget,patrolSpeed * Time.deltaTime);
        transform.LookAt(patrolTarget);
        if (Vector3.Distance(transform.position, patrolTarget) < 0.2)
        {
            if (patrolTarget == patrolPointB) patrolTarget = patrolPointA;
            else patrolTarget = patrolPointB;
        }
    }
    //追击算法
    public float chaseSpeed = 3f;
    void ChaseBehavior()
    {
        Debug.Log("追击！");
        transform.position = Vector3.MoveTowards(transform.position,player.position,chaseSpeed * Time.deltaTime);
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
            Debug.Log("攻击！");
            playerHealth.TakeDamage(attackATK);
            attackTimer = attackInterval;
        }
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        startPosition = transform.position;
        patrolPointA = startPosition + new Vector3(-patrolDistance, 0, 0);
        patrolPointB = startPosition + new Vector3(patrolDistance, 0, 0);
        patrolTarget = patrolPointB;
        playerHealth = player.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= attackRanfe) state = EnemyState.Attack;
        else if (distance <= detectRange) state = EnemyState.Chase;
        else state = EnemyState.Patrol;
        switch (state)
        {
            case EnemyState.Patrol:
            PatrolBehavior();
            break;
            case EnemyState.Chase:
            ChaseBehavior();
            break;
            case EnemyState.Attack:
            AttackBehavior();
            break;
        }
    }
}
