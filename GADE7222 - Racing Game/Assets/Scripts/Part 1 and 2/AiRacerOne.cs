using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRacerOne : AiVehicle
{
    public override void SetColour()//green
    {
        GameObject.FindObjectOfType<AiController>().agent.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    public override void SetSpeed()//40
    {
        GameObject.FindObjectOfType<AiController>().agent.speed = 40;
    }
}
