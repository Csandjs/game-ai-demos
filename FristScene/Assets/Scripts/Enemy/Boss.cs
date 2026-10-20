using System;
using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public enum BossState { Idle, Chase, Attack, Hurt, Dead }
    private BossState state = BossState.Idle;
    public int maxHp = 10;
    public int hp = 10;
    public float chaseSpeed = 2f;
    public float attackRange = 3.5f;
    private Transform player;
    private PlayerHealth playerHealth;
    public float hurtTime = 0.4f;
    private Coroutine attackRoutine;
    public event Action<int> OnHpChanged;
    public bool IsAlive => state != BossState.Dead;
    public bool enraged;

    [Header("外观（拖子物体）")]
    public Transform model;                 // 把 Pig W Root 拖进来
    private Vector3 modelBaseScale;
    public float attackBody = 1.15f;        // 单次攻击蓄力放大（别用2.5）
    public float enrageScale = 1.5f;        // 狂暴整体放大
    private Renderer bossRenderer;
    private Color originalColor;
    private Color enragedColor = new Color(1f, 0.4f, 0f);

    public int attackATK = 15;
    public float windupTime = 0.7f;
    public float recoverTime = 0.9f;
    private Animator animator;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        bossRenderer = GetComponentInChildren<Renderer>();
        animator = GetComponentInChildren<Animator>();
        originalColor = bossRenderer.material.color;
        modelBaseScale = model.localScale;
        state = BossState.Chase;
    }

    void ChaseBehavior()
    {
        Vector3 target = player.position;
        target.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, target, chaseSpeed * Time.deltaTime);
        transform.LookAt(target);
    }

    IEnumerator AttackCoroutine()
    {
        state = BossState.Attack;
        float t = 0;
        while (t < windupTime)              // 前摇：放大模型
        {
            t += Time.deltaTime;
            float p = t / windupTime;
            model.localScale = Vector3.Lerp(modelBaseScale, attackBody * modelBaseScale, p);
            Vector3 target = player.position;
            target.y = transform.position.y;
            transform.LookAt(target);
            yield return null;
        }
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= attackRange && !playerHealth.IsDead)
            playerHealth.TakeDamage(attackATK);

        t = 0;
        while (t < recoverTime)             // 后摇：缩回模型
        {
            t += Time.deltaTime;
            float p = t / recoverTime;
            model.localScale = Vector3.Lerp(attackBody * modelBaseScale, modelBaseScale, p);
            yield return null;
        }
        model.localScale = modelBaseScale;
        attackRoutine = null;
        state = BossState.Chase;
    }

    void Update()
    {
        if (GameManager.Instance.state != GameState.Playing) return;
        animator.SetFloat("Speed", state == BossState.Chase ? 1f : 0f);
        if (state == BossState.Chase) animator?.SetFloat("RunSpeed", chaseSpeed/4f);
        if (state == BossState.Idle || state == BossState.Hurt || state == BossState.Dead)
            return;
        if (state == BossState.Chase)
        {
            ChaseBehavior();
            if (Vector3.Distance(player.position, transform.position) <= attackRange)
                attackRoutine = StartCoroutine(AttackCoroutine());
        }
    }

    void EnterEnrage()
    {
        enraged = true;
        attackATK = 25;
        windupTime = 0.3f;
        recoverTime = 0.5f;
        chaseSpeed = 4f;
        modelBaseScale = enrageScale * modelBaseScale;
        model.localScale = modelBaseScale;
        bossRenderer.material.color = enragedColor;
    }

    public void TakeDamage(int dmg)
    {
        if (state == BossState.Dead) return;
        hp -= dmg;                          // 1.先扣血
        OnHpChanged?.Invoke(hp);
        AudioManager.Instance?.PlayHit();
        if (!enraged && hp <= maxHp * 0.3f) // 2.再判狂暴（只触发一次）
            EnterEnrage();
        if (hp <= 0)                        // 3.判死亡
        {
            StartCoroutine(DieRoutine());
            return;
        }
        if (state == BossState.Hurt) return;
        if (state == BossState.Attack)
        {
            if (enraged) return;            // 狂暴后攻击不被打断
            StopCoroutine(attackRoutine);
            attackRoutine = null;
            model.localScale = modelBaseScale;
        }
        StartCoroutine(HurtRoutine());
    }

    IEnumerator HurtRoutine()
    {
        state = BossState.Hurt;
        bossRenderer.material.color = Color.red;
        yield return new WaitForSeconds(hurtTime);
        if (state != BossState.Hurt) yield break;
        bossRenderer.material.color = enraged ? enragedColor : originalColor;
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
            float p = t / 0.8f;
            model.localScale = Vector3.Lerp(modelBaseScale, Vector3.zero, p);
            yield return null;
        }
        GameManager.Instance.WinGame();
        Destroy(gameObject);
    }
}
