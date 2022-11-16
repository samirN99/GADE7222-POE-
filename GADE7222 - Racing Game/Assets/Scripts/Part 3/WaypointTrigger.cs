using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTrigger : MonoBehaviour
{
    public int current_Point;
    public bool shortRoute = false;
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //return;
        //Debug.Log("checkpoint triggered");
        if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<Animator>().SetInteger("currentCheckpoint", current_Point);
        }
    }
}
