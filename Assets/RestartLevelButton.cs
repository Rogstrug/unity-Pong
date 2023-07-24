using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelButton : MonoBehaviour
{
 AudioSource audios;
   public AudioClip clip;
   
    void Start()
   {  
  audios=GetComponent<AudioSource>();   
   }
   
public void RestartLevel() 
{
  audios.PlayOneShot(clip);
    gameObject.SetActive(false);
  		  Scene scene = SceneManager.GetActiveScene(); 
          SceneManager.LoadScene(scene.name);
	Cursor.visible = false;
	Cursor.lockState = CursorLockMode.Locked;


}

public void ToMainMenu()
{
  audios.PlayOneShot(clip);
SceneManager.LoadScene("Main Menu");
}

}
