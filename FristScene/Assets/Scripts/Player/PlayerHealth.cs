using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour , IDamageable
{
    // Start is called before the first frame update
    private int hp = 100;
    public int maxHp = 100;
    public  int Hp
    {
        get => hp;
        private set => hp = Mathf.Clamp(value, 0, maxHp);
    }
    public bool IsDead => hp <= 0;
    public int damage = 10;
    public event Action<int> OnHpChanged;
    public void TakeDamage(int dmg)
    {
        if (IsDead) return;
        Hp -= dmg;        
        Debug.Log("受到伤害，掉" + dmg + "点血，剩余血量：" + hp);
        OnHpChanged?.Invoke(hp);
        if (IsDead)
        {
            GameManager.Instance.LoseGame();
        }
        AudioManager.Instance?.PlayHurt();
    }
    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            TakeDamage(damage);
        }
    }
    void Start()
    {
        OnHpChanged?.Invoke(hp);
    }
}
