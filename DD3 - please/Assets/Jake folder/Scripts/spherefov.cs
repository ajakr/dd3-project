using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherefov : MonoBehaviour
{
    public GameObject CurrentEnemy;
    public bool enemyInRange;
    public GameObject shooterHole;
    public Rigidbody Bullet;
    public Collider collder;
    private bool activey = false;
    // Start is called before the first frame update
    public void Awake()
    {
        
    }
    void Update()
    {
        if(enemyInRange==true && CurrentEnemy != null)
        {
            transform.LookAt(CurrentEnemy.transform.position, Vector3.up);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && CurrentEnemy == null)
        {
            CurrentEnemy = other.gameObject;
            enemyInRange = true;
            StartCoroutine("Attack");
            activey = true;
        }
    }    
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Enemy")
        {
            CurrentEnemy = null;
            enemyInRange = false;
            StopCoroutine("Attack");
            activey= false;
        }
    }
    private IEnumerator Attack()
    {
        if(CurrentEnemy != null)
        {
            yield return new WaitForSeconds(1);
            Shhootem();
            StartCoroutine("Attack");
        }        
    }
    public void Shhootem()
    {
        Rigidbody PEW;
        PEW = Instantiate(Bullet, shooterHole.transform.position, shooterHole.transform.rotation) as Rigidbody;
    }
}
