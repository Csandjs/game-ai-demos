using UnityEngine;
public class RebuildTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("获得战利品");
            Destroy(gameObject);
        }
    }
}
