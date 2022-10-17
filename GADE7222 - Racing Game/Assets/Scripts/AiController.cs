using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> waypoints = new List<GameObject>();

    //public GameObject[] aiWaypoints;
    WaypointManager wM;
    int waypointCounter = 0;
     GameObject target;
    public NavMeshAgent agent;
    void Start()
    {
        //AddWayPoints();
        //GetWayPoint();
        wM = FindObjectOfType<WaypointManager>();
        agent = GetComponent<NavMeshAgent>();
        AddWayPoints();
        GetWayPoint();
    }

    // Update is called once per frame
    void Update()
    {
        //agent.SetDestination(target.transform.position);
        LookAtWaypoint();
        agent.SetDestination(target.transform.position);
        //Debug.Log(waypointCounter);

    }

    private void AddWayPoints()
    {
        for (int i = 0; i < wM.aiWaypoints.Length; i++)
        {
            waypoints.Add(wM.aiWaypoints[i]);
        }
        Debug.Log("gg");
    }

    private void GetWayPoint()
    {
        target = waypoints[waypointCounter];
        waypointCounter++;
        //Debug.Log(waypoints[0].transform.position);
        if (waypointCounter == 24)
        {
            waypointCounter = 0;
            //target = waypoints[waypointCounter];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "waypoint")
        {
            GetWayPoint();
        }
    }

    void LookAtWaypoint()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion look = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, look, Time.deltaTime * 5f);
    }

    


}
