using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public CoinSpawner spawner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectCoin((int)GameConfig.Get("coinValue"));
            spawner.RemoveCoin(gameObject);
            Destroy(gameObject);
        }
    }
}
