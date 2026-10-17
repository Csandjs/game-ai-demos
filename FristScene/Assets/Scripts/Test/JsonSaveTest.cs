using UnityEngine;

public class JsonSaveTest : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.HasKey("SaveDate"))
        {
            string json = PlayerPrefs.GetString("SaveData");
            SaveData d = JsonUtility.FromJson<SaveData>(json);
            Debug.Log("找到存档" + json);
            Debug.Log("最高分=" + d.highScore + "最近分=" + d.lastScore + "解锁=" + d.unlockedLevel);
        }
        else
        {
            Debug.Log("没有存档，第一次玩");
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            SaveData d = new SaveData();
            d.highScore = 100;
            d.lastScore = 50;
            d.unlockedLevel = 2;
            string json = JsonUtility.ToJson(d);
            PlayerPrefs.SetString("SaveData", json);
            PlayerPrefs.Save();
            Debug.Log("已存档：" + json);
        }
    }
}
