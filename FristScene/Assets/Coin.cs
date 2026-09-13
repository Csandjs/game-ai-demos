using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public static int score = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score = score + 1;
            Debug.Log("吃到金币！当前分数：" + score);
            Destroy(gameObject);
        }
    }
}
