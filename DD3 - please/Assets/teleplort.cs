using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleplort : MonoBehaviour
{
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void YClick()
    {
        gameObject.transform.position = Spawner.transform.position;
        gameObject.transform.rotation = Spawner.transform.rotation;
    }
}
