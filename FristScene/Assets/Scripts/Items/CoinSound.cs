using Unity.VisualScripting;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnCoinCollected +=CollectCoinSound;
    }
    public void CollectCoinSound(int amount)
    {
        Debug.Log("【音效】：叮！");
    }
    void OnDestroy()
    {
        GameManager.Instance.OnCoinCollected -= CollectCoinSound;
    }
}
