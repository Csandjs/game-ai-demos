using UnityEngine;
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
    public ScoreUI scoreUI;
    public GameObject winText;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void AddScore(int amount)
    {
        score = score + amount;
        scoreUI.RefreshScore(score);
    }
    public void WinGame()
    {
        state = GameState.Win;
        winText.SetActive(true);
    }
}
