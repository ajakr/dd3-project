using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cannon;
    public Transform spawnerTransform;
    void Start()
    {
        
    }
    public void Update()
    {
        spawnerTransform = GameObject.Find("spawner").transform;
    }

    public void cannonspawn()
    {
        Debug.Log("spawn");
        Instantiate(cannon);
    }
}
