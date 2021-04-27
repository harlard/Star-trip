using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoyAsteroid : MonoBehaviour
{
    public float Speed;
    public GameObject Target;
    Vector3 direction;

    void start1(){
      direction = new Vector3(Random.Range(-3.0f,3.0f),Random.Range(-4.0f,0f),0).normalized; //random position in x and y
          }

    // Update is called once per frame
    void Update(){
            transform.position +=  direction * Speed * Time.deltaTime;
    }

}
