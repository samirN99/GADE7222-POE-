using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> waypoints = new List<GameObject>();
    public GameObject[] aiWaypoints;
    int waypointCounter = 0;
    GameObject target;
    NavMeshAgent agent;
    void Start()
    {
        AddWayPoints();
        GetWayPoint();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Acceleration = Mathf.Lerp( speed, 2.5f * Time.deltaTime);
        //Vector3 turnDirection = transform.TransformDirection(Vector3.forward);
        //turnDirection.y -= 100f * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, target,speed * Time.deltaTime);
        LookAtWaypoint();
        agent.SetDestination(target.transform.position);
    }

    private void AddWayPoints()
    {
        for (int i = 0; i < aiWaypoints.Length; i++)
        {
            waypoints.Add(aiWaypoints[i]);
        }
    }

    private void GetWayPoint()
    {
        target = waypoints[waypointCounter];
        waypointCounter++;
        Debug.Log(waypointCounter);
        if (waypointCounter == 23)
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
