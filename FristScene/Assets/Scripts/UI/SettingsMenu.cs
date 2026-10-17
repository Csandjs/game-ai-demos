using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider volumeSlider;
    public GameObject startPanel;
    public Button settingsButton;
    public Button backButton;
    void OnSettingsClick()
    {
        startPanel.SetActive(false);
        settingsPanel.SetActive(true);
    } 
    void OnBackClick()
    {
        startPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
    void OnVolumeSlider(float value)
    {
        SaveManager.SaveVolume(value);
        Debug.Log("拖动滑块，已存音量：" + value);
    }
    void Start()
    { 
        volumeSlider.value = AudioListener.volume = SaveManager.LoadVolume();
        settingsButton.onClick.AddListener(OnSettingsClick);
        backButton.onClick.AddListener(OnBackClick);
        volumeSlider.onValueChanged.AddListener(OnVolumeSlider);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
