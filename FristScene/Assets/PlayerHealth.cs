using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 100;
    public int damage = 10;
    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            hp = hp - damage;        
            Debug.Log("碰到机关，掉" + damage + "点血，剩余血量：" + hp);
        }
    }
}
