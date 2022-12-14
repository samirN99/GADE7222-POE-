using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Checkpoints : MonoBehaviour
{
    CourseTimer time;
    CheckpointTracker c;
    int laps = 1;
    public TextMeshProUGUI lapCounter;
    public GameObject winPanel;
    SFXManager sfx;

    private void Start()
    {
        sfx = FindObjectOfType<SFXManager>();
        time = FindObjectOfType<CourseTimer>();
        c = FindObjectOfType<CheckpointTracker>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Checkpoint Race")
            {
                time.trackTime = time.trackTime + 7f;
                sfx.PlaySound("checkpoint");
                c.NextCheckpoint();
            }
            else
            {
                laps++;
                lapCounter.text = "Lap " + laps + "/3";
                if (laps == 4)
                {
                    winPanel.SetActive(true);
                }
            }
        }
    }
}
