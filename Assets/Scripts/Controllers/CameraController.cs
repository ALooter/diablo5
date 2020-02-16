using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
    public Quaternion rotation;

    void LateUpdate()
    {
        transform.rotation = rotation;
        transform.position = player.position - offset;
        //transform.LookAt(player.position);
    }
}
