using UnityEngine;
using System;
//单例
public enum GameState
{
    Playing,
    Win
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public GameState state = GameState.Playing;
    public GameObject winText;
    public event Action<int> OnCoinCollected;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
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
    public void WinGame()
    {
        state = GameState.Win;
        winText.SetActive(true);
    }
}
