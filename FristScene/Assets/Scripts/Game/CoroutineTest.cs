using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }
    IEnumerator TimerCoroutine()
    {
        Debug.Log("对局开始");
        yield return null;
        Debug.Log("第一帧加载完成");
        yield return new WaitForSeconds(3f);
        Debug.Log("红Buff刷新");
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log("第" + i + "波小兵出发");
            yield return new WaitForSeconds(1f);
        }
    }
    void Update()
    {
        
    }
}
