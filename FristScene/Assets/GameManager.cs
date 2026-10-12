using UnityEngine;
using System;
//单例
public enum GameState
{
    StartGame,
    Playing,
    Paused,
    Win
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public GameState state = GameState.StartGame;
    public GameObject winText;
    public GameObject restarButton;
    public event Action<int> OnCoinCollected;
    void Awake()
    {
        Instance = this;
        Time.timeScale = 1;
        //DontDestroyOnLoad(gameObject);
        OnCoinCollected += AddScore;
        state = GameState.Playing;
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    public void CollectCoin(int amount)
    {
        OnCoinCollected?.Invoke(amount);
    }
    public void WinGame()
    {
        state = GameState.Win;
        winText.SetActive(true);
        restarButton.SetActive(true);
    }
}
