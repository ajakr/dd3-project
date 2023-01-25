using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherefov : MonoBehaviour
{
    public GameObject CurrentEnemy;
    public bool enemyInRange;
    public GameObject shooterHole, Bullet;
    // Start is called before the first frame update
    void Update()
    {
        if(enemyInRange==true)
        {
            transform.LookAt(CurrentEnemy.transform.position, Vector3.up);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            CurrentEnemy = other.gameObject;
            enemyInRange = true;
            StartCoroutine("Attack");
        }
    }    
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Enemy")
        {
            enemyInRange = false;
            StopCoroutine("Attack");
            Destroy(CurrentEnemy);
        }
    }
    private IEnumerator Attack()
    {
        Shhootem();
        yield return new WaitForSeconds(1);
        StartCoroutine("Attack");
    }
    public void Shhootem()
    {
        Instantiate(Bullet, shooterHole.transform.position, Quaternion.identity);
    }
}
