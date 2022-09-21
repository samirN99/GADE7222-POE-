using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    CourseTimer time;
    CheckpointTracker c;

    private void Start()
    {
        time = FindObjectOfType<CourseTimer>();
        c = FindObjectOfType<CheckpointTracker>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            time.trackTime = time.trackTime + 7f;
            c.NextCheckpoint();
        }
    }
}
