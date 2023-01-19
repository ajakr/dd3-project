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
    public bool checkedEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        playerinattack = Physics.CheckSphere(transform.position, attackRange, enemies);
        while(playerinattack == true)
        {
            if(checkedEnemy == false)
            {
                CheckEnemy();
                checkedEnemy = true;
            }
            AttackEnemy();
        }
        
    }
    void CheckEnemy()
    {
        Collider[] enemyhitcollider = Physics.OverlapSphere(transform.position, attackRange, enemies);
        for(int i = 0; i<=enemyhitcollider.Length; i++)
        {
            currentEnemy = enemyhitcollider[i].gameObject;
            break;
        }
    }
    void AttackEnemy()
    {
        StopCoroutine("CheckingForEnemy");
        transform.LookAt(currentEnemy.transform);
    }

}
