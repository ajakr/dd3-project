using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
  void Awake()
  {
      gameObject.transform.Translate(0, 15, 0);
  }
}