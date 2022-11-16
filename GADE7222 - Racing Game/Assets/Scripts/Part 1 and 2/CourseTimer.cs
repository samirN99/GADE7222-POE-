using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CourseTimer : MonoBehaviour
{
    public float trackTime;
    float seconds;
    public TMPro.TextMeshProUGUI displayTime;
    float readyTimer = 4f;
    bool ready = false;
    public GameObject player;
    public GameObject aiRacer;
    public GameObject losePanel;
    SFXManager sfx;

    private void Start()
    {
        sfx = FindObjectOfType<SFXManager>();
        player.GetComponent<ShipController>().enabled = false;
        aiRacer.GetComponent<AiController>().enabled = false;
        losePanel.SetActive(false);
    }
    void Update()
    {
        if (trackTime > 0)
        {
            trackTime -= Time.deltaTime;
            readyTimer -= Time.deltaTime;
        }
        else
        {
            trackTime = 0;
            readyTimer = 0;

        }

        DisplayReady(readyTimer);
        if (ready == true)
        {
            DisplayTime(trackTime);
        }
        if (trackTime == 0)
        {
            displayTime.text = "You Lose";
            player.GetComponent<ShipController>().enabled = false;
            losePanel.SetActive(true);
        }

    }

    private void DisplayTime(float currentTime)
    {
        if (trackTime > 0)
        {
            seconds = Mathf.FloorToInt(currentTime);
            displayTime.text = seconds.ToString();
        }
    }

    private void DisplayReady(float time)
    {
        if (ready == false)
        {
            //sfx.PlaySound("rev");
            sfx.PlaySound("timer");
            time = Mathf.FloorToInt(time);
            if (time == 3)
            {
                displayTime.text = "On your marks";
            }
            else if (time == 2)
            {
                displayTime.text = "Get set";
                //sfx.PlaySound("timer");
            }
            else if (time == 1)
            {
                displayTime.text = "Go";
                //sfx.PlaySound("timer");
            }
            else 
            {
                ready = true;
                player.GetComponent<ShipController>().enabled = true;
                player.GetComponent<AiController>().enabled = true;
            }
        }
    }

}
