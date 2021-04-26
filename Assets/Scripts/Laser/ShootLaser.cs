using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
  public GameObject LaserRay;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.Space) != false){
        LaserRay.SetActive(true);
      }
      else {
        LaserRay.SetActive(false);
      }

    }
}
