using System.Collections;
using UnityEngine;

public class CloseBookSpawmer : MonoBehaviour
{
    public GameObject enemyPrefabs;
    public bool isRunning;
    public Transform spawnPoint;
    Coroutine coroutine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isRunning) return;
            isRunning = true;
            coroutine = StartCoroutine(SpawnRoutine());
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
                coroutine = null;
            }
        }
    }
    IEnumerator SpawnRoutine()
    {
        int i = 5;
        while(i > 0)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(enemyPrefabs, spawnPoint.position, Quaternion.identity);
            i--;
        }
        isRunning = false;
        coroutine = null;
    }
    public void StopSpawn()
    {
        StopCoroutine(coroutine);
    }
}
