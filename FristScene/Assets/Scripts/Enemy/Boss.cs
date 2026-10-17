using System;
using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public enum BossState
    {
        Idle, Chase, Attack, Hurt, Dead
    }
    private BossState state = BossState.Idle;
    public int maxHp = 6;
    public int hp = 6;
    public float chaseSpeed = 2f;
    public float attackRange = 3.5f;
    private Transform player;
    private PlayerHealth playerHealth;
    public float hurtTime = 0.4f;
    private Coroutine attackRoutine;
    public event Action<int> OnHpChanged;
    public bool IsAlive => state != BossState.Dead;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        bossRenderer = GetComponent<Renderer>();
        originalColor = bossRenderer.material.color;
        baseScale = transform.localScale;
        state = BossState.Chase;
    }
    void ChaseBehavior()
    {
        Vector3 target = player.position;
        target.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, target, chaseSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
    public int attackATK = 15;
    public float windupTime = 0.7f;
    public float recoverTime = 0.9f;
    private Renderer bossRenderer;
    private Color originalColor;
    private Vector3 baseScale;
    IEnumerator AttackCoroutine()
    {
        state = BossState.Attack; 
        bossRenderer.material.color = Color.red;
        float t = 0;
        while(t < windupTime)
        {
            t += Time.deltaTime;
            float p = t/windupTime;
            transform.localScale = Vector3.Lerp(baseScale, 1.15f * baseScale, p);
            Vector3 target = player.position;
            target.y = transform.position.y;
            transform.LookAt(target);
            yield return null;
        }
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= attackRange && !playerHealth.IsDead)
        {
            playerHealth.TakeDamage(attackATK);
        }
        bossRenderer.material.color = originalColor;
        t = 0;
        while (t < recoverTime)
        {
            t += Time.deltaTime;
            float p = t/recoverTime;
            transform.localScale = Vector3.Lerp(baseScale * 1.15f, baseScale, p);
            yield return null;
        }
        attackRoutine = null;
        state = BossState.Chase;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.state != GameState.Playing)return;
        if (state == BossState.Idle || state == BossState.Hurt || state == BossState.Dead)
        {
            return;
        }
        if (state == BossState.Chase)
        {
            ChaseBehavior();
            if (Vector3.Distance(player.position, transform.position) <= attackRange)
            {
                attackRoutine = StartCoroutine(AttackCoroutine());
            }
        }
        else if (state == BossState.Attack)
        {
            
        }
    }
    public void TakeDamage(int dmg)
    {
        if (state == BossState.Dead) return;
        hp -= dmg;
        OnHpChanged?.Invoke(hp);
        if (hp <= 0)
        {
            StartCoroutine(DieRoutine());
            return;
        }
        AudioManager.Instance?.PlayHit();
        if (state == BossState.Hurt) return;
        if(state == BossState.Attack)
        {
            StopCoroutine(attackRoutine);
            attackRoutine = null;
            transform.localScale = baseScale;
            bossRenderer.material.color = originalColor;
        }
        StartCoroutine(HurtRoutine());
    }
    IEnumerator HurtRoutine()
    {
        state = BossState.Hurt;
        bossRenderer.material.color = Color.yellow;
        yield return new WaitForSeconds(hurtTime);
        if (state != BossState.Hurt) yield break;
        bossRenderer.material.color = originalColor;
        state = BossState.Chase;
    }
    IEnumerator DieRoutine()
    {
        state = BossState.Dead;
        if (attackRoutine != null)
        {
            StopCoroutine(attackRoutine);
            attackRoutine = null;
        }
        bossRenderer.material.color = Color.gray;
        float t = 0;
        while (t < 0.8f)
        {
            t += Time.deltaTime;
            float p = t/0.8f;
            transform.localScale = Vector3.Lerp(baseScale,baseScale * 0,p);
            yield return null;
        }
        GameManager.Instance.WinGame();
        Destroy(gameObject);
    }
}
