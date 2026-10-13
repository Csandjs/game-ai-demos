using UnityEngine;

public class AxisMove : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log("水平h=" + h + "前后v=" + v );
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
}
