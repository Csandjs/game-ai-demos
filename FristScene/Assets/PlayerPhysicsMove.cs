using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPhysicsMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();//把挂在同一个Cube上的刚体组件取出来，存进rb
    }
    //持续的物理移动放在FixedUpdate
    void FixedUpdate()
    {
        float moveX = 0f;
        float moveZ = 0f;
        if (Input.GetKey(KeyCode.W))moveZ = 1f;
        if (Input.GetKey(KeyCode.S))moveZ = -1f;
        if (Input.GetKey(KeyCode.A))moveX = -1f;
        if (Input.GetKey(KeyCode.D))moveX = 1f;
     
        rb.velocity = new Vector3 (moveX * moveSpeed,rb.velocity.y,moveZ * moveSpeed);
    }
    //瞬间的跳跃检测放在Update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce ,ForceMode.Impulse);
        }
    }
    //碰到东西认为落地了
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true ;
    }
    //离开东西认为在空中
    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
