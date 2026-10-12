using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    private Button backButton;
    void OnBackClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }
    void Start()
    {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(OnBackClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
