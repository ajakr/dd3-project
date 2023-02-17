using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyMove : MonoBehaviour
{
    public GameObject goal;
    public Vector3 goalloacation;
    public NavMeshAgent agent;
    public ThirdPerson character;
   
    void Start()
    {
        goalloacation =  goal.transform.position;
        agent.SetDestination(goalloacation);
        
    }

    
    void Update()
    {
       if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    
    }
}
