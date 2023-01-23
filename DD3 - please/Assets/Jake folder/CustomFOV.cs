using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFOV : MonoBehaviour
{
    public LayerMask enemies;
    public float attackRange;
    public bool playerinattack;
    public GameObject currentEnemy;
    private void Update()
    {
        playerinattack = Physics.CheckSphere(transform.position, attackRange, enemies);
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange, enemies);
        foreach(Collider hitCollider in hitColliders)
        {
            currentEnemy = hitCollider.GetComponent<Collider>().transform.parent.gameObject;
        }
    }
    
    private void Start()
    {
        StartCoroutine("gct");
    }
    private IEnumerator gct()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);
        
        yield return wait;
    }
}
