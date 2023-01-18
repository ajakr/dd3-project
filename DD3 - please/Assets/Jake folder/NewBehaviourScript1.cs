using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject goal;
    public Transform goallocation;
    // Start is called before the first frame update
    void Start()
    {
        goallocation = goal.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
