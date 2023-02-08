using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour

{
    public int waveCount;
    public int enemyCount;
    public float waveTextTimer = 1.0f;
    public float spawnRate = 1.0f;
    public float timesBetweenWaves = 5.0f; 
    public GameObject enemies;

    [SerializeField]
    public bool isWaveActive = true;
    public bool stopSpawning = false;
    
    // Start is called before the first frame update
    
    IEnumerator waveSpawner()
    {
        while(isWaveActive == true && stopSpawning == false)
        {
            Vector3 spawnPos = new Vector3(Random.Range(5f, 1f), 0f, 0f);
            int randomEnemy = Random.Range(0, 0);
            isWaveActive = false;

            for (int i = 0; i < enemyCount; i++)
            {   
                ActivateWaveText();
                yield return new WaitForSeconds(waveTextTimer);
                Debug.Log("asdkfeada");
                Instantiate(enemies, spawnPos, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate);
            }
        }
    }
    
    void Start()
    {
        StartCoroutine(waveSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActivateWaveText()
    {

    }
}
