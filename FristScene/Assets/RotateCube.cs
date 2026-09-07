using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float rotateSpeed_x = 50f;
    public float rotateSpeed_y = 50f;
    public float rotateSpeed_z = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateSpeed_x,rotateSpeed_y,rotateSpeed_z)*Time.deltaTime);
    }
}
