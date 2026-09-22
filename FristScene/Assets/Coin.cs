using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public CoinSpawner spawner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectCoin(1);
            spawner.RemoveCoin(gameObject);
            Destroy(gameObject);
        }
    }
}
