using System.Collections.Generic;
using UnityEngine;

static class GameConfig
{
    private static Dictionary<string , float> config = new Dictionary<string, float>
    {
        {"moveSpeed" , 8f} , {"jumpForce" , 5f} , {"coinValue" , 1f}
    };
    public static float Get(string key)
    {
        if (config.TryGetValue(key, out float value))
        {
            return value;
        }
        else
        {
            Debug.LogWarning("缺少配置，返回默认值");
            return 0;
        }
    }
}