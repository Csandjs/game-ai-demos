using UnityEngine;

public class RebuildMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float speedX = 0;
        float speedZ = 0;
        if (Input.GetKey(KeyCode.W)) speedZ = 1;
        if (Input.GetKey(KeyCode.S)) speedZ = -1;
        if (Input.GetKey(KeyCode.A)) speedX = -1;
        if (Input.GetKey(KeyCode.D)) speedX = 1;

        rb.velocity = new Vector3(speedX * speed, rb.velocity.y,speedZ * speed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
