using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
  public GameObject spawnerobj;
  public Vector3 spawnerV3;
    // Start is called before the first frame update
  void Awake()
  {
      spawnerobj = GameObject.Find("spawner");
    gameObject.transform.position = spawnerobj.transform.position;
  }
}