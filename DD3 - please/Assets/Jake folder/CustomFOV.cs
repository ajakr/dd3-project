using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFOV : MonoBehaviour
{
    public float viewRange = 12f;
    public LayerMask enemies;
    public float timeBetweenAtacks;
    bool alreadyAttacked;
    public float attackRange;
    public bool playerinattack;
    public GameObject currentEnemy;
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
        playerinattack = Physics.CheckSphere(transform.position, attackRange, enemies);
        if(playerinattack == true)
        {
            CheckEnemy();
            AttackEnemy();
        }
    }

    void CheckEnemy()
    {
        Collider[] enemyhitcollider = Physics.OverlapSphere(transform.position, attackRange, enemies);
        
        GameObject currentEnemy = enemyhitcollider.transform.parent.gameObject;
    }
    void AttackEnemy()
    {
        StopCoroutine("CheckingForEnemy");
        transform.LookAt(currentEnemy);
    }

}
