using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour
{
  public float MovementSpeed = 1;
  public float movementMinX = 4;
  public float movementMaxX = -4;
  public float movementMinY = 4;
  public float movementMaxY = -4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    float movementx = Input.GetAxis("Horizontal");
    float movementy = Input.GetAxis("Vertical");


      transform.position += new Vector3(movementx, movementy, 0).normalized * Time.deltaTime * MovementSpeed;
      transform.position = new Vector3(Mathf.Clamp(transform.position.x, movementMinX, movementMaxX), Mathf.Clamp(transform.position.y, movementMinY, movementMaxY), transform.position.z);

    }
}
