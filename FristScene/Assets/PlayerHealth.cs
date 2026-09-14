using UnityEngine;

public class PlayerHealth : MonoBehaviour , IDamageable
{
    // Start is called before the first frame update
    public  int hp = 100;
    public int damage = 10;
    public void TakeDamage(int dmg)
    {
        hp = hp - dmg;        
        Debug.Log("受到伤害，掉" + dmg + "点血，剩余血量：" + hp);
    }
    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            TakeDamage(damage);
        }
    }
}
