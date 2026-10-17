using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDirector : MonoBehaviour
{
    public Text bossText;
    public GameObject boss;
    public GameObject bossHpSlider;
    void Start()
    {
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
