using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMotion : MonoBehaviour
{
    public Transform model;
    public float spinSoeed = 180f;
    public float bobAmount = 0.15f;
    public float bobFrep = 3 ;
    void Start()
    {
        
    }
    void HoverUpdate()
    {
        transform.Rotate(new Vector3(0, spinSoeed, 0) * Time.deltaTime);
        Vector3 p = model.localPosition;
        p.y = Mathf.Sin(Time.time * bobFrep) * bobAmount;
        model.localPosition = p;
    }
    void Update()
    {
        HoverUpdate();
    }
}
