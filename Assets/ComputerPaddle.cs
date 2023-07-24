
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    AudioSource audios;
    public AudioClip clip;
    
     void Start()
  {
  audios=GetComponent<AudioSource>();
  
  if(MainMenuScript.tezina==3){
  transform.localScale= new Vector3(0.3f, 3.5f, 1f);
  }
  else if(MainMenuScript.tezina==2)
  transform.localScale = new Vector3 (0.3f, 2.5f,1f);
  else if(MainMenuScript.tezina==1)
  transform.localScale = new Vector3 (0.3f, 2f,1f);
}


void OnCollisionEnter2D(Collision2D other)
{

if(other.gameObject.name=="Ball")
audios.PlayOneShot(clip);

}
    
    
    
    
    
	void FixedUpdate(){
	
	if(this.ball.velocity.x<0.0f)
	{
	
	if(this.ball.position.y>this.transform.position.y)
	{
	_rigidbody.AddForce(Vector2.up* MainMenuScript.speed);
	}
	else if(this.ball.position.y<_rigidbody.position.y)
	_rigidbody.AddForce(Vector2.down* MainMenuScript.speed);	
	}//ball.vel
	
	else{
	
	if(_rigidbody.position.y>0.0f)
	{
	_rigidbody.AddForce(Vector2.down* 100f);
	}
	else if(_rigidbody.position.y<0.0f) _rigidbody.AddForce(Vector2.up* 100f);
	
	}
	
	}//fixed
}
