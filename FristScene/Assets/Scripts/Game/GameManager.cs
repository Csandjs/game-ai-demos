using UnityEngine;
using System;
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
    public GameState state;
    public GameObject winText;
    public GameObject restarButton;
    public GameObject loseText;
    public event Action<int> OnCoinCollected;
    void Awake()
    {
        Instance = this;
        state = GameState.Playing;
        AudioListener.volume = PlayerPrefs.GetFloat(GameConfig.VolumeKey, 1f);
        Debug.Log("进游戏时音量：" + AudioListener.volume);
        Time.timeScale = 1;
        //DontDestroyOnLoad(gameObject);
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
    public void SaveHighScoreIfNeeded()
    {
        int highScore = PlayerPrefs.GetInt(GameConfig.HighScoreKey,0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt(GameConfig.HighScoreKey,score);
            Debug.Log("刷新最高分：" + score);
        }
    }
    public void WinGame()
    {
        if (state != GameState.Playing) return;
        state = GameState.Win;
        winText.SetActive(true);
        SaveHighScoreIfNeeded();
        AudioManager.Instance?.PlayWin();
    }
    public void LoseGame()
    {
        if (state != GameState.Playing) return;
        state = GameState.Lose;
        loseText.SetActive(true);
        SaveHighScoreIfNeeded();
        AudioManager.Instance?.PlayLose();
    }
}
