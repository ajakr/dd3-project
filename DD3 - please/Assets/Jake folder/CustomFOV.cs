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
    public bool checkedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("cannoncheck");
    }


    public IEnumerator cannoncheck()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);
        yield return wait;
        playerinattack = Physics.CheckSphere(transform.position, attackRange, enemies);
    }

    public void Update()
    {
        
        while(playerinattack == true)
        {
            if(checkedEnemy == false)
            {
                checkedEnemy = true;
                CheckEnemy();
            }
        }
        
    }
    void CheckEnemy()
    {
        Debug.Log("ahesahoogah");
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
