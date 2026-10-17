using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public Button continueButton;
    public Button settingsButton;
    public GameObject settingsPanel;
    public Button backButton;
    public Slider volumeSlider;
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
    void OnBackClick()
    {
        pausePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
    void OnSettingsClick()
    {
        pausePanel.SetActive(false);
        settingsPanel.SetActive(true);
    } 
    void OnVolumeSlider(float value)
    {
        SaveManager.SaveVolume(value);
        Debug.Log("滑动音量条，已存音量：" + value);
    }
    void Start()
    {
        volumeSlider.value = AudioListener.volume = SaveManager.LoadVolume();
        continueButton.onClick.AddListener(OnContinueClick);
        settingsButton.onClick.AddListener(OnSettingsClick);
        backButton.onClick.AddListener(OnBackClick);
        volumeSlider.onValueChanged.AddListener(OnVolumeSlider);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (settingsPanel.activeSelf)
            {
                OnBackClick();
            }
            else if(GameManager.Instance.state == GameState.Playing)
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
