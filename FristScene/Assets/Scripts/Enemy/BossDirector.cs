using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BossDirector : MonoBehaviour
{
    public Text bossText;
    public GameObject bossObj;
    private Boss boss;
    public GameObject bossHpSlider;
    private Transform player;
    public EnemySpawner enemySpawner;
    bool isTrigger;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        boss = bossObj.GetComponent<Boss>();

    }
    IEnumerator BossAppear()
    {
        yield return new WaitForSeconds(1f);
        bossText.text = "Boss即将降临";
        int bossIncomingTime = 3;
        yield return new WaitForSeconds(3f);
        while (bossIncomingTime > 0)
        {
            bossText.text = "还有" + bossIncomingTime + "S";
            yield return new WaitForSeconds(1f);
            bossIncomingTime--;
        }

        Vector3 dir = new Vector3(player.position.x - bossObj.transform.position.x,
       0, player.position.z - bossObj.transform.position.z); // 玩家相对于Boss的方向向量
        if (dir.magnitude < 0.01f)//向量长度（位置）< 0.01
        {
            dir = Vector3.back;//vector3.back 是 (0, 0, -1);
        }
        if (dir.magnitude < 5.5f)
        {
            dir.Normalize();//长度缩成1，方向不变
            player.position = new Vector3(bossObj.transform.position.x, player.position.y, bossObj.transform.position.z)
            + new Vector3(dir.x * 5.5f, 0, dir.z * 5.5f);
            //将玩家逼退至离Boss5.5米远处
        }

        bossObj.SetActive(true);
        bossHpSlider.SetActive(true);
        bossText.text = "Boss降临";
        yield return new WaitForSeconds(0.5f);
        bossText.text = "击倒Boss获取游戏胜利";

    }
    void Update()
    {
        if (enemySpawner.isOver && enemySpawner.Enemies.Count == 0)
        {
            if (!isTrigger)
            {
                isTrigger = true;
                StartCoroutine(BossAppear());
            }
        }
        if (boss.enraged)
        {
            bossText.text = "Boss进入狂暴状态了!小心!!!";
        }
    }
}
