using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOhhh : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject HitThing;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 15f, ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision other)
    {
        HitThing = other.gameObject;
        Destroy(gameObject);
        if(HitThing.tag == "Enemy")
        {
            //hurt Enemy
        }
    }
}
