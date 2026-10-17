using UnityEngine;
using UnityEngine.UI;

public class BossHpUI : MonoBehaviour
{
    private Slider bossHpSlider;
    public Boss boss;
    void Start()
    {
        bossHpSlider = GetComponent<Slider>();
        bossHpSlider.maxValue = boss.maxHp;
        bossHpSlider.value = boss.hp;
        boss.OnHpChanged += RefreshHp;
    }
    public void RefreshHp(int hp)
    {
        bossHpSlider.value = hp;
        if(hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        
    }
    void OnDestroy()
    {
        boss.OnHpChanged -= RefreshHp;
    }
}
