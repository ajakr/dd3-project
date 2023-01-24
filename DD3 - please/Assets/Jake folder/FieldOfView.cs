using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float radius;
    [Range(0,360)]
    public float angle;
    public GameObject enemyUnits;
    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;

    private void Start()
    {
        enemyUnits = GameObject.FindGameObjectWithTag("Enemy");
        StartCoroutine(FOVRoutine());
    }

    private IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

     public void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);
        if (rangeChecks.Length != 0)
        {
            for (int i = 0; i <= rangeChecks.Length; i++)
            {
                canSeePlayer = true;
                enemyUnits = rangeChecks[i].gameObject;
                break;

            }

            Transform target = enemyUnits.transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    canSeePlayer = true;
                }
                else
                {
                    canSeePlayer = false;
                    enemyUnits = null;
                }

            }
            else
            {
                canSeePlayer = false;
                enemyUnits = null;
            }
        }
        else if (canSeePlayer)
        {
            canSeePlayer = false;
            enemyUnits = null;
        }
        
    }

}
