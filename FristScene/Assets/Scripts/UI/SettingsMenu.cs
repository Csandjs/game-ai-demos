using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider volumeSlider;
    public GameObject startPanel;
    public Button settingsButton;
    public Button backButton;
    public Toggle musicToggle;
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
    void OnVolumeToggle(bool isOn)
    {
        SaveManager.SaveMusicOn(isOn);
        AudioManager.Instance.SetMusicOn(isOn);
    }
    void Start()
    { 
        volumeSlider.value = AudioListener.volume = SaveManager.LoadVolume();
        musicToggle.isOn = SaveManager.LoadMusicOn();
        settingsButton.onClick.AddListener(OnSettingsClick);
        backButton.onClick.AddListener(OnBackClick);
        volumeSlider.onValueChanged.AddListener(OnVolumeSlider);
        musicToggle.onValueChanged.AddListener(OnVolumeToggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
