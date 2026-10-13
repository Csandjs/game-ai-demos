using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHealth : MonoBehaviour , IDamageable
{
    public int durability = 30;
    public void TakeDamage(int dmg)
    {
        durability = durability - dmg;
        Debug.Log("木箱受到" + dmg + "点破坏，剩余耐久：" + durability);
        if (durability <= 0)
        {
            Debug.Log("木箱被摧毁了！");
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
