using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    public Slider hpSlider;
    public Text stateText;
    private Enemy enemy;
    void Start()
    {
        enemy = GetComponentInParent<Enemy>();
        hpSlider.maxValue = enemy.maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        hpSlider.value = enemy.hp;
        switch (enemy.CurrentState)
        {
            case Enemy.EnemyState.Patrol:
            stateText.text = "巡逻";
            break;
            case Enemy.EnemyState.Idle:
            stateText.text = "待机"; 
            break;
            case Enemy.EnemyState.Chase:
            stateText.text = "追击";
            break;
            case Enemy.EnemyState.Attack:
            stateText.text = "攻击";
            break;
        }
    }
    void LateUpdate()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
