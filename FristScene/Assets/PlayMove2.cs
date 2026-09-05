using UnityEngine;

public class PlayerMove2:MonoBehaviour
{
    public float moveSpeed = 5f;

void Update()
    {
        float h = Input.GetAxis("Horizontal");
         float v = Input.GetAxis("Vertical");

          Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.World);
    }
}