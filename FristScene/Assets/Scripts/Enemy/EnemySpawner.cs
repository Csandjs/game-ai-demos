using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    List<Enemy> enemies = new List<Enemy>();
    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        Debug.Log("剩余敌人：" + enemies.Count);
        if(enemies.Count == 0)
        {
            GameManager.Instance.WinGame();
        }
    }
    private Transform player;
    public float playerAttackRange = 100f;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        for (int i = 1; i < 6; i++)
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(2f, 30f);
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(x, 1f, z), Quaternion.identity);
            Enemy e = enemy.GetComponent<Enemy>();
            e.spawner = this;
            enemies.Add(e);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            List<Enemy> targets = enemies.FindAll(e => e.hp > 0 && 
            Vector3.Distance(e.transform.position, player.position) <= playerAttackRange);
            foreach(Enemy e in targets)
            {
                e.Die();
            }
        }
    }
}
