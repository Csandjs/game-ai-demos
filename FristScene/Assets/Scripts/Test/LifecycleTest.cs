using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class LifecycleTest : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    void Update()
    {
        Debug.Log("Update");
    }
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
