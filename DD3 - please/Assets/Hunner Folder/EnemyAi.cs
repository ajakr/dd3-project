using UnityEngine;
using UnityEngine.AI;
public class EnemyAi : MonoBehaviour
{
   public NavMeshAgent agent;
   
   public Transform player;
   
   public LayerMask whatIsGround, whatIsPlayer;

   public float timeBetweenattacks;
   bool alreadyAttacked;

   public float sightRange, attackRange;
   public bool playerInSightRange, playerInAttackRange;

   private void Awake()
   {
       enemy = GameObject.Find("canon").transform;
       agent = GetComponent<NavMeshAgent>();
   }

}
