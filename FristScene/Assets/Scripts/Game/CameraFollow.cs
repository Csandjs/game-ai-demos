using JetBrains.Annotations;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offest = new Vector3(0f, 8f, -8f);
    void LateUpdate()
    {
        transform.position = player.position + offest;
        transform.LookAt(player);
    }
}
