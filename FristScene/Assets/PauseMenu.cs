using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public Button continueButton;
    void Pause()
    {
        GameManager.Instance.state = GameState.Paused;
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    void OnContinueClick()
    {
        GameManager.Instance.state = GameState.Playing;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    void Start()
    {
        continueButton.onClick.AddListener(OnContinueClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameManager.Instance.state == GameState.Playing)
            {
                Pause();
            }
            else if (GameManager.Instance.state == GameState.Paused)
            {
                OnContinueClick();
            }
        }
    }
}
