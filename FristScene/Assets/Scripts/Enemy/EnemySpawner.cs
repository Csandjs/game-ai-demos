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
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(1f, 1f, i * 1f),Quaternion.identity);
            Enemy e = enemy.GetComponent<Enemy>();
            e.spawner = this;
            enemies.Add(e);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            List<Enemy> targets = enemies.FindAll(e => e.hp >0);
            foreach(Enemy e in targets)
            {
                e.Die();
            }
        }
    }
}
