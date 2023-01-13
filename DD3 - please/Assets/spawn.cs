using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
  private GameObject spawnerobj;
  private Vector3 spawnerV3;
    // Start is called before the first frame update
  void Awake()
  {
      spawnerobj = GameObject.Find("spawner");
      spawnerV3 = spawnerobj.transform.position;
      gameObject.transform.Translate(spawnerV3);
  }
}