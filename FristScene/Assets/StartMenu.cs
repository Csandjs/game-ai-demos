using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    private Button startButton;
    void OnStartClick()
    {
        Debug.Log("游戏开始");
        SceneManager.LoadScene("MiniLevel");
    }
    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(OnStartClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
