using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    // Start is called before the first frame update
    private Text playerHpText;
    public PlayerHealth player;
    void Start()
    {
        playerHpText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHpText.text = "血量：" + player.hp;
    }
}
