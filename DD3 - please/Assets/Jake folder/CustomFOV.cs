using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFOV : MonoBehaviour
{
    public float viewRange = 12f;
    public LayerMask enemies;
    public float timeBetweenAtacks;
    bool alreadyAttacked;
    public float sightRange, attackRange;
    public bool playerinsight, playerinattack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if(playerinattack == false)
        {
            StartCoroutine("CheckingForEnemy");
        }
        
    }

    // Update is called once per frame
    IEnumerator CheckingForEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    void FieldOfViewCheck()
    {
        playerinattack = Physics.CheckSphere(transform.position, sightRange, enemies);
        if(playerinattack == true)
        {
            AttackEnemy();
        }
    }


    void AttackEnemy()
    {
        StopCoroutine("CheckingForEnemy");
    }
}
