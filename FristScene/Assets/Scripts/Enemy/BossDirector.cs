using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDirector : MonoBehaviour
{
    public Text bossText;
    public GameObject boss;
    public GameObject bossHpSlider;
    private Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        StartCoroutine(BossAppear());
    }
    IEnumerator BossAppear()
    {
        int bossIncomingTime = 3;
        yield return new WaitForSeconds(5f);
        while (bossIncomingTime > 0)
        {
            bossText.text = "还有" + bossIncomingTime + "S";
            yield return new WaitForSeconds(1f);
            bossIncomingTime--;
        }

        Vector3 dir = new Vector3(player.position.x - boss.transform.position.x,
       0, player.position.z - boss.transform.position.z); // 玩家相对于Boss的方向向量
        if (dir.magnitude < 0.01f)//向量长度（位置）< 0.01
        {
            dir = Vector3.back;//vector3.back 是 (0, 0, -1);
        }
        if (dir.magnitude < 5.5f)
        {
            dir.Normalize();//长度缩成1，方向不变
            player.position = boss.transform.position + new Vector3(dir.x * 5.5f, 0, dir.z * 5.5f);
            //将玩家逼退至离Boss5.5米远处
        }

        boss.SetActive(true);
        bossHpSlider.SetActive(true);
        bossText.text = "Boss降临";
        yield return new WaitForSeconds(0.5f);
        bossText.text = "击倒boss获取游戏胜利";
    }
    void Update()
    {

    }
}
