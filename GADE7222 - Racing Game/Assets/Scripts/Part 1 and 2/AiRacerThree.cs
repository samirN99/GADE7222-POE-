using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRacerThree : AiVehicle
{
    public override void SetColour()
    {
        GameObject.FindObjectOfType<AiController>().agent.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
    }

    public override void SetSpeed()
    {
        GameObject.FindObjectOfType<AiController>().agent.speed = 60;
    }
}
