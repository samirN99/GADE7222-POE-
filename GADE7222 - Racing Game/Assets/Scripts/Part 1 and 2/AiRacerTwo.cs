using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRacerTwo : AiVehicle
{
    public override void SetColour()
    {
        GameObject.FindObjectOfType<AiController>().agent.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }

    public override void SetSpeed()
    {
        GameObject.FindObjectOfType<AiController>().agent.speed = 50;
    }
}
