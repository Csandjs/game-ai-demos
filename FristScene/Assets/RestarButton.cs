using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RestarButton : MonoBehaviour
{
    private Button restarButton;
    void OnRestarClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Start()
    {
        restarButton = GetComponent<Button>();
        restarButton.onClick.AddListener(OnRestarClick);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
