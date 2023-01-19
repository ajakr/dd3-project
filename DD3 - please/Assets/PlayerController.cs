using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    public GameObject goal;
    public Vector3 goalloacation;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        goalloacation =  goal.transform.position;
        agent.SetDestination(goalloacation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
