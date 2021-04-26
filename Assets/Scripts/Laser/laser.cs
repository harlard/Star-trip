using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
  [SerializeField]private float defDistanceRay = 100;
  public Transform laserFirePoint;
  public LineRenderer m_LineRenderer;
  public float Power = 1;
  Transform m_transform;

  private void Awake(){
    m_transform = GetComponent<Transform>();
      }

  private void Update(){

        ShootLaser();


  }
  void ShootLaser(){
       if (Physics2D.Raycast(m_transform.position, transform.right)){
      RaycastHit2D _hit = Physics2D.Raycast(laserFirePoint.position, transform.right);
      Draw2DRay(laserFirePoint.position, _hit.point);
          }
          else {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * defDistanceRay);
          }

  }

  void Draw2DRay(Vector2 startPos, Vector2 endPos){
    m_LineRenderer.SetPosition(0, startPos);
    m_LineRenderer.SetPosition(1, endPos);
  }



}
