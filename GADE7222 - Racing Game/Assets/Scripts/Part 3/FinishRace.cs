using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishRace : MonoBehaviour
{
    public TextMeshProUGUI lap;
    int lapNum = 1;
    public GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lapNum++;
            lap.text = "Lap " + lapNum + "/3";
            if (lapNum == 4)
            {
                winPanel.SetActive(true);
            }
        }
    }
}
