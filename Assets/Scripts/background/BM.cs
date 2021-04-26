using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM : MonoBehaviour
{
  public float BackgroundSpeed = 1;
  public float BackgroundBegin = 0;
  public float BackgroundEnd = 4;
      void Start()
    {

    }
    void Update()
    {


    transform.position += new Vector3(0, -BackgroundSpeed, 0) * Time.deltaTime;
    transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y,  BackgroundEnd, BackgroundBegin), transform.position.z);

    }
}
