using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AdvancedAI : MonoBehaviour
{
    public Vector3 target;
    public NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtWaypoint();
        agent.SetDestination(target);
    }

    void LookAtWaypoint()
    {
        Vector3 direction = (target - transform.position).normalized;
        Quaternion look = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, look, Time.deltaTime * 5f);
    }
}
