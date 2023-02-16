using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checksphere : MonoBehaviour
{
    public bool enemyInRange = false;
    public float range = 4.0f;
    public LayerMask EnemyLayer;
    public GameObject CurrentEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyInRange = false)
        {
            Collider[] Other = Physics.OverlapSphere(transform.position, range, EnemyLayer);
            foreach (var hitCollider in Other)
            {
                hitCollider.SendMessage("AddDamage");
            }
            

            
        }  
    }
}
