using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trajectoy : MonoBehaviour
{
    public float MinSpeed;
    public float MaxSpeed;
    public float Speed;
    public float Accuracity;
    public Transform Target;

    void Start()
    {
    Speed = Random.Range(MinSpeed, MaxSpeed);
    transform.position += new Vector3(Target.transform.position.x, Target.transform.position.y, 0).normalized * Speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
