using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTracker : MonoBehaviour
{
    public GameObject[] targets = new GameObject[5];
    public Stack<GameObject> tracker;
    public GameObject checkpoint;
    public GameObject winPanel;
    void Start()
    {
        tracker = new Stack<GameObject>();
        for (int i = 4; i >= 0; i--)
        {
            tracker.Push(targets[i]);
        }
        checkpoint.transform.position = tracker.Peek().transform.position;
        //print(tracker.Peek().transform.position);
       
    }

    public void NextCheckpoint()
    {
        tracker.Pop();
        if (tracker.Count == 0)
        {
            winPanel.SetActive(true);
        }
        else
        {
            checkpoint.transform.position = tracker.Peek().transform.position;
        }
    }
}
