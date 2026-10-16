using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class LevelSceneSetup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winText;
    public GameObject loseText;
    void Start()
    {
        GameManager.Instance.RegisterLevel(winText, loseText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
