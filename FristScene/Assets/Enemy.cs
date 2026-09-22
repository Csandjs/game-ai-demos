using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 1;
    public EnemySpawner spawner;
    public void Die()
    {
        hp = hp -1;
        if(hp <= 0)
        {
            spawner.RemoveEnemy(this);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Die();
        }
    }
}
