using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    private Button startButton;
    public GameObject loadingPanel;
    public Slider loadingSlider;
    void OnStartClick()
    {
        Debug.Log("游戏开始");
        loadingPanel.SetActive(true);
        StartCoroutine(LoadingCoroutine("MiniLevel"));
    }
    IEnumerator LoadingCoroutine(string sceneName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        op.allowSceneActivation = false;
        while (op.progress < 0.9f)
        {
            yield return null;
            loadingSlider.value = op.progress/0.9f;
        }
        loadingSlider.value = 1f;
        yield return new WaitForSeconds(1f);
        op.allowSceneActivation = true;
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
