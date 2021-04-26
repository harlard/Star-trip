using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoyAsteroid : MonoBehaviour
{
    public float Speed;
    public GameObject Target;
    Transform direction;


    void start(){
        getDirection();
    }

    // Update is called once per frame
    void Update()
    {
    transform.position += direction * Speed * Time.deltaTime;
    }
    void getDirection(){
      direction += (transform.position - Target.transform.position).normalized;
      }

}
