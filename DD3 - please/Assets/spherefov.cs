using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherefov : MonoBehaviour
{
    public GameObject CurrentEnemy;
    public bool enemyInRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            CurrentEnemy = other.gameObject;
            StartCoroutine("Attack");
        }
    }    
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Enemy")
        {
            StopCoroutine("Attack");
            Destroy(CurrentEnemy);
        }
    }
    private IEnumerator Attack()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("BAM");
    }

}
