using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cannon;
    public GameObject spawner;
    private Transform spawnerTransform;
    void Start()
    {
        cannon = GameObject.Find("cannon");
        spawner = GameObject.Find("spawner");
        
    }
    void Update()
    {
        Transform spawnerTransform = GetComponent<Transform>();
    }

    public void cannonspawn()
    {
        Instantiate(cannon, spawnerTransform);
    }
}
