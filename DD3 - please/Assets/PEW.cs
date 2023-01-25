using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEW : MonoBehaviour
{
    public spherefov spherefov;
    Rigidbody bulletrb;
    public float force = 20f;
    // Start is called before the first frame update
    void Awake()
    {
        bulletrb = GetComponent<Rigidbody>();
        bulletrb.AddForce(spherefov.CurrentEnemy.transform.position * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
