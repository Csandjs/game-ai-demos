using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    private Button quitButton;
    void OnQuitClick()
    {
        Application.Quit();
    }
    void Start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(OnQuitClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
