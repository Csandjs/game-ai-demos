using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//金币生成
public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    List<GameObject> coins = new List<GameObject>();
    public void RemoveCoin(GameObject coin)
    {
        coins.Remove(coin);
        Debug.Log("剩余金币：" + coins.Count);
    }
    void Start()
    {
        for(int i = 0 ;i < 10; i++)
        {
            GameObject coin = Instantiate(coinPrefab,new Vector3(1.5f, 1f, i * 1f),Quaternion.identity);
            Coin coinScript = coin.GetComponent<Coin>();
            coinScript.spawner = this;
            coins.Add(coin);
            Debug.Log("生成金币数量：" + coins.Count);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
