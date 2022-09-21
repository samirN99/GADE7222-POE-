using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerShip;
    public Vector3 offset;
    void Update()
    {
        //transform.position = playerShip.position + offset;
        //transform.LookAt(playerShip);
        transform.position = playerShip.position + offset;
        //transform.rotation = playerShip.rotation;
        //transform.rotation = playerShip.transform.rotation;
    }

    private void LateUpdate()
    {
        //transform.position = playerShip.position + offset;
    }
}
