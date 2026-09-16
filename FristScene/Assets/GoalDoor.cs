using UnityEngine;
//终点脚本
public class GoalDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.WinGame();
        }
    }
}
