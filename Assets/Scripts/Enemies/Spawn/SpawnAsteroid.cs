using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
public GameObject object2Copy;
public float xPos;
public float yPos;
public int enemyCount;
public int time;
private int fc = 0;

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
      Spawn();
    }
    void Spawn(){
      ++fc;
      if(fc>time){
      Instantiate(object2Copy, new Vector3(xPos, yPos, -1f), Quaternion.identity);
      fc = 0;
      }
    }
}
