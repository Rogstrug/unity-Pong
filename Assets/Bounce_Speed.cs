using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Speed : MonoBehaviour
{
  public float bounceStrenght;
  
  private void OnCollisionEnter2D(Collision2D  collision)
  {
  
  Ball ball=collision.transform.GetComponent<Ball>();
  
  if(ball != null)
  {
  Vector2 normal = collision.GetContact(0).normal;
  ball.AddForce(-normal*bounceStrenght);
  }
  
  } 
   
}
