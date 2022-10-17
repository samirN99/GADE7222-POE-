using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAiRacer : MonoBehaviour
{
    public GameObject spawnPos;
    public GameObject aiPrefab;
    AiRacerFactory factory;
    void Start()
    {
        //factory = FindObjectOfType<AiRacerFactory>();

        SpawnAi();
    }

    private void SpawnAi()
    {
        Instantiate(aiPrefab, spawnPos.transform.position, Quaternion.identity);
    }
}
