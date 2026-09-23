using UnityEngine;

public class PlayerPhysicsMove : MonoBehaviour , IMovable
{
    public float moveSpeed;
    public float jumpForce;
    public float groundDistance = 0.55f;
    public float moveAcceleration = 15f;
    private Rigidbody rb;
    private Animator animator;
    private bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();//把挂在同一个Cube上的刚体组件取出来，存进rb
        animator = GetComponent<Animator>();
        moveSpeed = GameConfig.Get("moveSpeed");
        jumpForce = GameConfig.Get("jumpForce");
    }
    public void Move()
    {
        float moveX = 0f;
        float moveZ = 0f;
        if (Input.GetKey(KeyCode.W))moveZ = 1f;
        if (Input.GetKey(KeyCode.S))moveZ = -1f;
        if (Input.GetKey(KeyCode.A))moveX = -1f;
        if (Input.GetKey(KeyCode.D))moveX = 1f;

        //目标速度
        Vector3 targetVelocity = new Vector3(moveX * moveSpeed , rb.velocity.y, moveZ * moveSpeed);
        //这一帧速度最多能变多少；
        float maxChange = moveAcceleration * Time.fixedDeltaTime;
        Vector3 v = rb.velocity;
        //Mathf.MoveTowards(当前值v.x , 目标值 , 每步最大变化量)
        v.x = Mathf.MoveTowards(v.x ,targetVelocity.x,maxChange);
        v.z = Mathf.MoveTowards(v.z ,targetVelocity.z,maxChange);    
        rb.velocity = v;
        animator.SetBool("isMoving",moveX != 0 || moveZ != 0);
    }
    //持续的物理移动放在FixedUpdate
    void FixedUpdate()
    {
        if (GameManager.Instance.state == GameState.Win)
        {
            animator.SetBool("isMoving" , false);
            animator.SetBool("isJumping" , false);
            return;
        }
        Move();
    }
    //瞬间的跳跃检测放在Update
    void Update()
    {
        if (GameManager.Instance.state == GameState.Win)
        {
            return;
        }
        isGrounded = Physics.Raycast(transform.position ,Vector3.down ,groundDistance);
        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);
        //Debug.Log("射线打到地面了吗：" + HitGround);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce ,ForceMode.Impulse);
        }
        animator.SetBool("isJumping", !isGrounded);
    }
    //碰到东西认为落地了
    // void OnCollisionEnter(Collision collision)
    // {
    //     if ( collision.gameObject.CompareTag("Ground"))
    //     isGrounded = true ;
    // }
    // //离开东西认为在空中
    // void OnCollisionExit(Collision collision)
    // {
    //     if(collision.gameObject.CompareTag("Ground"))
    //     isGrounded = false;
    // }
}