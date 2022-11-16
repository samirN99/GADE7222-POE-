using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishRace : MonoBehaviour
{
    public TextMeshProUGUI lap;
    int lapNum = 1;
    public GameObject winPanel;
    SFXManager sfx;

    private void Start()
    {
        sfx = FindObjectOfType<SFXManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lapNum++;
            lap.text = "Lap " + lapNum + "/3";
            sfx.PlaySound("checkpoint");
            if (lapNum == 4)
            {
                winPanel.SetActive(true);
            }
        }
    }
}
