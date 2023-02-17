using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnerEnemy : MonoBehaviour

{

    private int waveCount;
    private int enemyCount;
    private float waveTextTimer = 1.0f;
    private float spawnRate = 1.0f;
    private float timesBetweenWaves = 5.0f; 
    private GameObject[] enemies;
    private int randomEnemy;
    
    [SerializeField]
    private bool isWaveActive = true;
    private bool stopSpawning = false;
    
    [SerializeField]
    private TextMeshProUGUI waveCountTxt;



    
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(waveSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    
    
    IEnumerator waveSpawner()
    {
        while(isWaveActive == true && stopSpawning == false)
        {
            Vector3 spawnPos = new Vector3(Random.Range(5f, 1f), 0f, 0f);
            int randomEnemy = Random.Range(0, 0);
            isWaveActive = true;

            for (int i = 0; i < enemyCount; i++)
            {   
                ActivateWaveText();
                yield return new WaitForSeconds(waveTextTimer);
                GameObject enemyClone = Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);
                Debug.Log("asdkfeada");
                
                yield return new WaitForSeconds(spawnRate);
            }
        }
        spawnRate -= 1.0f;
        enemyCount += 1;
        yield return new WaitForSeconds(timesBetweenWaves);
        waveCount +=1;
        isWaveActive = true;
    }
    





    public void ActivateWaveText()
    {
        waveCountTxt.text = waveCount.ToString();

        waveCountTxt.gameObject.SetActive(true);
    }
}
