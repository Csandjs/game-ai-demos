using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public static int score = 0;
    public ScoreUI scores;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score = score + 1;
            scores.RefreshScore(score);
            Debug.Log("吃到金币！当前分数：" + score);
            Destroy(gameObject);
        }
    }
}
