using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//单例
public enum GameState
{
    Playing,
    Paused,
    Win,
    Lose
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    private Text winResultText;
    private Text loseResultText;
    public GameState state;
    public GameObject winText;
    public GameObject loseText;
    //总管进入新场景时，得到两个物体
    public void RegisterLevel(GameObject win, GameObject lose)
    {
        score = 0;
        winText = win;
        loseText = lose;
        winResultText = win.GetComponentInChildren<Text>(true);
        loseResultText = lose.GetComponentInChildren<Text>(true);
        winText.SetActive(false);
        loseText.SetActive(false);
        Time.timeScale = 1;
        state = GameState.Playing;
    }
    public event Action<int> OnCoinCollected;
    void Awake()
    {  
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        state = GameState.Playing;
        AudioListener.volume = SaveManager.LoadVolume();
        Debug.Log("进游戏时音量：" + AudioListener.volume);
        Time.timeScale = 1;
        OnCoinCollected += AddScore;
        
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    public void CollectCoin(int amount)
    {
        OnCoinCollected?.Invoke(amount);
    }
    //游戏胜利
    public void WinGame()
    {
        if (state != GameState.Playing) return;
        state = GameState.Win;
        winText.SetActive(true);
        SaveManager.SaveHighScore(score);
        SaveManager.SaveLastScore(score);
        winResultText.text ="游戏胜利" + "\n本局得分：" + score + "\n最高分：" + SaveManager.LoadHighScore();
        AudioManager.Instance?.PlayWin();
    }
    //游戏失败
    public void LoseGame()
    {
        if (state != GameState.Playing) return;
        state = GameState.Lose;
        loseText.SetActive(true);
        SaveManager.SaveHighScore(score);
        SaveManager.SaveLastScore(score);
        loseResultText.text = "游戏失败" + "\n本局得分：" + score + "\n最高分：" + SaveManager.LoadHighScore();
        AudioManager.Instance?.PlayLose();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
