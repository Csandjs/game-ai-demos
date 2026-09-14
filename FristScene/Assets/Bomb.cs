using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public int bombDamage = 30;
    public KeyCode explodekey = KeyCode.K;
    private List<IDamageable> targetsInRange = new List<IDamageable>();
    void OnTriggerEnter(Collider other)
    {
        IDamageable d = other.GetComponent<IDamageable>();
        if (d != null && !targetsInRange.Contains(d))
        {
            targetsInRange.Add(d);
        }
    }
    void OnTriggerEXit(Collider other)
    {
        IDamageable d = other.GetComponent<IDamageable>();
        if (d != null && !targetsInRange.Contains(d))
        {
            targetsInRange.Remove(d);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(explodekey))
        {
            Debug.Log("炸弹爆炸！范围内有" + targetsInRange.Count + "个可受伤对象");
            foreach(IDamageable d in targetsInRange)
            {
                if (d != null)
                {
                    d.TakeDamage(bombDamage);
                }
            }
            targetsInRange.Clear();
        }
    }
}
