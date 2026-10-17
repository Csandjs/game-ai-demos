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
    //整包存取
    public static void SaveGame(int highScore, int lastScore, int unlockedLevel)
    {
        SaveData d = new SaveData();
        d.highScore = highScore;
        d.lastScore = lastScore;
        d.unlockedLevel = unlockedLevel;
        string json = JsonUtility.ToJson(d);
        PlayerPrefs.SetString(GameConfig.SaveDataKey, json);
        PlayerPrefs.Save();
        Debug.Log("已存档" + json);
    }
    public static SaveData LoadGame()
    {
        if (PlayerPrefs.HasKey(GameConfig.SaveDataKey))
        {
            string json = PlayerPrefs.GetString(GameConfig.SaveDataKey);
            SaveData d = JsonUtility.FromJson<SaveData>(json);
            Debug.Log("已读取存档" + json);
            return d;
        }
        else
        {
            return new SaveData();
        }
    }
    //删除整包进度
    public static void ClearSave()
    {
        PlayerPrefs.DeleteKey(GameConfig.SaveDataKey);
        PlayerPrefs.Save();
    }
    //清空所有进度
    public static void ClearAll()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
