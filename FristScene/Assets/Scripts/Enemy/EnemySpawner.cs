using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] waypoints;
    List<Enemy> enemies = new List<Enemy>();
    public List<Enemy> Enemies => enemies;
    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        Debug.Log("剩余敌人：" + enemies.Count);
        UpdateCountUI();
    }
    void UpdateCountUI()
    {
        quantity.text = "剩余敌人：" + enemies.Count;
    }
    private Transform player;
    public Boss boss;
    public float playerAttackRange = 4f;
    public float spawnInterval = 2f;
    Coroutine spawnHandle;
    public bool isOver = false;
    public int outPut = 10;
    public Text quantity;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        spawnHandle = StartCoroutine(SpawnEnemies());
        UpdateCountUI();
    }
    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < outPut; i++)
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(2f, 30f);
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(x, 1f, z), Quaternion.identity);
            Enemy e = enemy.GetComponent<Enemy>();
            e.spawner = this;
            e.waypoints = this.waypoints;
            enemies.Add(e);
            UpdateCountUI();
            yield return new WaitForSeconds(spawnInterval);
            if (GameManager.Instance.state != GameState.Playing) break;
            
        }
        isOver = true;
    }

    void Update()
    {
        if (GameManager.Instance.state != GameState.Playing) return;
        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(0))
        {
            List<Enemy> targets = enemies.FindAll(e => e.hp > 0 && 
            Vector3.Distance(e.transform.position, player.position) <= playerAttackRange);
            foreach(Enemy e in targets)
            {
                e.Die();
            }
            if (boss != null && 
            boss.gameObject.activeInHierarchy && 
            boss.IsAlive && 
            Vector3.Distance(boss.transform.position, player.position) <= playerAttackRange)
            {
                boss.TakeDamage(1);
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            StopCoroutine(spawnHandle);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StopAllCoroutines();
        }
    }
}
