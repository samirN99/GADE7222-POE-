using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public GameObject[] checkpoints;

    public Vector3 GetCheckPoints(int point, bool cheat = false)
    {
        foreach (GameObject c in checkpoints)
        {
            if (c.GetComponent<WaypointTrigger>().current_Point == point && c.GetComponent<WaypointTrigger>().shortRoute == cheat)
            {
                return c.transform.position;
            }
        }
        return new Vector3();
    }
}
