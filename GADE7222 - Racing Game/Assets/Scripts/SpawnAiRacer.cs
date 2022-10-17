using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAiRacer : MonoBehaviour
{
    public GameObject spawnPos;
    public GameObject aiPrefab;
    //AiRacerFactory factory;
    void Start()
    {
        //SpawnAi();
        //factory.GetAiVehicle();
        //AiVehicle vehicle = factory.GetAiVehicle();
        var factory = new AiRacerOne();
        SpawnAi();
        //SpawnAi();
    }

    private void SpawnAi()
    {
        Instantiate(aiPrefab, spawnPos.transform.position, Quaternion.identity);
    }
}
