using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkillCooldown : MonoBehaviour
{
    public Text cdText;
    public float cooldownTime = 3f;
    bool isCooling = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (isCooling) return;
            Debug.Log("释放技能");
            StartCoroutine(CooldownCoroutine());
        }
    }
    IEnumerator CooldownCoroutine()
    {
        isCooling = true;
        float remainTime = cooldownTime;
        while(remainTime > 0)
        {
            cdText.text = "CD:" + remainTime;
            yield return new WaitForSeconds(1f);
            remainTime--;
        }
        cdText.text = "技能就绪";
        isCooling = false;
    }
}
