using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public Text LastScoreText;
    void Start()
    {
        LastScoreText.text = "最近得分:" + SaveManager.LoadLastScore();
        GetComponent<Text>().text = "最高分：" + SaveManager.LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
