using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        GameManager.Instance.OnCoinCollected += RefreshScore;
    }
    public void RefreshScore(int amount)
    {
        scoreText.text = "分数：" + GameManager.Instance.score;
    }

    void OnDestroy()
    {
        GameManager.Instance.OnCoinCollected -= RefreshScore;
    }
}