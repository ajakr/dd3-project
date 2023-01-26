using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int  Dmgnt = 20;

    public void Update()
    {
        if(Dmgnt <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("ow");
            Dmgnt = (Dmgnt-5);
        }
    }
}
