using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
public bool pauseAct=false;
public GameObject panel;


    public void exit()
	{  
	Application.Quit();
	}
	
	public void mainMenu()
	{
	SceneManager.LoadScene("Main Menu");
	}
	
	public void Restart()
	{
          panel.SetActive(false);
  		  Scene scene = SceneManager.GetActiveScene(); 
          SceneManager.LoadScene(scene.name);
	Cursor.visible = false;
	Cursor.lockState = CursorLockMode.Locked;
		}
	
	void Update()
	{

if(Input.GetKeyDown(KeyCode.Escape))
{
if(pauseAct)
Resume();
else
Pause();

}	
	}
	
	
	void Resume()
	{
	
 panel.SetActive(false);
         Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;
         pauseAct=false;
         Time.timeScale = 1f;
	}
	
	void Pause()
	{
	
	panel.SetActive(true);
	pauseAct=true;
	 Cursor.visible = true;
         Cursor.lockState = CursorLockMode.None;
         Time.timeScale = 0f;	
	}
}
