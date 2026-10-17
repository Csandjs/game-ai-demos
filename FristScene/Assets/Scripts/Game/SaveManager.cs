using UnityEngine;

static class SaveManager
{
    public static void SaveVolume(float volumeValue)
    {
        PlayerPrefs.SetFloat(GameConfig.VolumeKey, volumeValue);
        AudioListener.volume = volumeValue;
    }
    public static float LoadVolume()
    {
        return PlayerPrefs.GetFloat(GameConfig.VolumeKey,1f);
    }
    public static void SaveHighScore(int score)
    {
        int oldScore = PlayerPrefs.GetInt(GameConfig.HighScoreKey,0);
        if (score > oldScore)
        {
            PlayerPrefs.SetInt(GameConfig.HighScoreKey,score);
        }
    }
    public static int LoadHighScore()
    {
        return PlayerPrefs.GetInt(GameConfig.HighScoreKey,0);
    }
    public static void SaveLastScore(int score)
    {
        PlayerPrefs.SetInt(GameConfig.LastScoreKey,score);
    }
    public static int LoadLastScore()
    {
        return PlayerPrefs.GetInt(GameConfig.LastScoreKey, 0);
    }
}
