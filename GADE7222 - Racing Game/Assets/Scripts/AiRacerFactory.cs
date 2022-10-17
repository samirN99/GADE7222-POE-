using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRacerFactory
{
    //int randomRacer;
    public AiVehicle GetAiVehicle(int randomRacer)
    {
        //randomRacer = Random.Range(0, 3);
        if (randomRacer == 0)
        {
            return new AiRacerOne();
        }
        else if (randomRacer == 1)
        {
            return new AiRacerTwo();
        }
        else
        {
            return new AiRacerThree();
        }
    }

}
