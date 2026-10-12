using UnityEngine;
using UnityEngine.UI;
public class HpUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider hpSlider;
    private Text playerHpText;   
        void Start()
    {
        playerHpText = GetComponent<Text>();
    }
    public void RefreshHp(int hp)
    {
        playerHpText.text = "血量：" + hp;
        hpSlider.value = hp;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
