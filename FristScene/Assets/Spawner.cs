using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab; 
    public float bulletSpeed = 10f;
    
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.J)))
        {
            GameObject ball = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            //在发射器自身位置生成预制体billetPrefab
            Rigidbody rb = ball.GetComponent<Rigidbody>();//取出新球的刚体
            rb.velocity = transform.forward * bulletSpeed;//给他“发射器正前方 * 速度”
        }
    }
}
