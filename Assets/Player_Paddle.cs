using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Paddle : Paddle
{
    Vector2 _direction;
    AudioSource audios;
    
      public AudioClip clip;
    void Start()
  {
  audios=GetComponent<AudioSource>();
}
    
    
void OnCollisionEnter2D(Collision2D other)
{

if(other.gameObject.name=="Ball")
audios.PlayOneShot(clip);

}
    
    
    
    
    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
		_direction=Vector2.up;
		}
		else if(Input.GetKey(KeyCode.DownArrow)){
		_direction=Vector2.down;
		}
		else
		_direction=Vector2.zero;
    }
    
    void FixedUpdate()
    {
    if(_direction.sqrMagnitude != 0){
	_rigidbody.AddForce(_direction * MainMenuScript.playerSpeed);
	}
}//Fixed
}
