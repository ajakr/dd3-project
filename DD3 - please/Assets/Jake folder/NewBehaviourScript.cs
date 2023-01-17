using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cannon;
    public Transform spawnerTransform;

    public void cannonspawn()
    {
        Debug.Log("spawn");
        Instantiate(cannon);
    }
}
