using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{   
    public int score1,score2;
    Vector2 direction;
    float x;
    float y;
    public float speed;
    Rigidbody2D rb;
    public AudioClip clip,clip2;
    private bool scoredWait;
    AudioSource audios;
    public GameObject canvas;
    [SerializeField] GameObject[] texts_for_win;
    [SerializeField] GameObject[] texts_for_loss;
    GameObject txtWin,txtLoss;
    
    
    void Awake()
    {
    
    rb=GetComponent<Rigidbody2D>();
        Time.timeScale=1f;
    }
    void Start()
    {
    Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        canvas.SetActive(false);
     txtWin = texts_for_win[UnityEngine.Random.Range(0, texts_for_win.Length)];
	 txtLoss = texts_for_loss[UnityEngine.Random.Range(0, texts_for_loss.Length)];    
    
        audios=GetComponent<AudioSource>();
        Invoke("StartingForce",1f);
    }
    
    
 
    
    void Update()
	{
	

	
	
	if(score1==3 || score2==3)
	{
	Time.timeScale=0f;
	Cursor.visible = true;
	Cursor.lockState = CursorLockMode.None;
	canvas.SetActive(true);
	
	if(score1==3)
	txtWin.SetActive(true);
	else if(score2==3)
	txtLoss.SetActive(true);
			 	
	}//if
	
	}//update
    
    
    

    
    public void StartingForce()
	{
gameObject.GetComponent<TrailRenderer>().enabled=true; 
	 x = Random.value;
	if(x<0.5)
	x=-1.0f;
	else
	x=1.0f;
	
	y=Random.value;
	if(y<0.5)
	y=Random.Range(-1.0f,-0.5f);
	else
	y=Random.Range(0.5f,1.0f);
	
	direction=new Vector2(x,y);
	
	rb.AddForce(direction*speed);
	
	}
	
	public void AddForce(Vector2 vector)
	{
	rb.AddForce(vector);
	}
	
	
	  void OnTriggerEnter2D(Collider2D coll)
    {
	
	if(coll.gameObject.name=="Left_Trigger")
	{
	  audios.PlayOneShot(clip2);
	  score1++;
	  gameObject.GetComponent<TrailRenderer>().enabled=false; 
	  rb.velocity=Vector3.zero;
	  transform.position = new Vector3(0, 0, 0);
	  
	  Invoke("StartingForce",1f);
	  
	}	
	
	if(coll.gameObject.name=="Right_Trigger")
	{
	  audios.PlayOneShot(clip2);
	  score2++;
	  gameObject.GetComponent<TrailRenderer>().enabled=false; 
	  rb.velocity=Vector3.zero;
	  transform.position = new Vector3(0, 0, 0);
	  Invoke("StartingForce",1f);
	   
	}		
	}
	
void OnCollisionEnter2D(Collision2D other)
{

if(other.gameObject.tag=="walll")
audios.PlayOneShot(clip);

}



		
}
