using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    public void RefreshScore(int score)
    {
        scoreText.text = "分数：" + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
