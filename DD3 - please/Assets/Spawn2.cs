using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn2 : MonoBehaviour
{
    public int waveCount;
    public int enemyCount;
    public float spawnRate = 1.0f;
    public float timesBetweenWaves = 5.0f; 
    public GameObject[] enemies;
    public bool spawning = true;
    public bool notSpawning = false;
    
    void Start()
    {
  //      StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (spawning == true && notSpawning == false)
        {
           Instantiate enemies
        }
    } 

    void Update()
    {
        
    }
}
