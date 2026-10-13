using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "最高分：" + PlayerPrefs.GetInt(GameConfig.HighScoreKey, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
