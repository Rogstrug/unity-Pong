using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
   public GameObject difficultyPanel, verSusPanel, optionsPanel,slider;
   public static float speed,playerSpeed; 
   public Button pveB, pvpB;
   [SerializeField] Slider volumeSlider;
   AudioSource audios;
   public AudioClip clip;
   public static int tezina;
   
   void Start()
   {
  
  audios=GetComponent<AudioSource>();
   
   }

   public void StartTheGame()
   {
   audios.PlayOneShot(clip);
   verSusPanel.SetActive(false);
   difficultyPanel.SetActive(true);
   pvpB.interactable=true;
   optionsPanel.SetActive(false);
   slider.SetActive(false);
    }//start the game
    
    
    public void EasyMode()
    {  audios.PlayOneShot(clip);
	 speed=150f;
	 playerSpeed=200f;
	 tezina=1;
	 SceneManager.LoadScene("Pve");
	}
	
	 public void MedMode()
    {  audios.PlayOneShot(clip);
     playerSpeed=175f;
	 speed=375f;
	 tezina=2;
	 SceneManager.LoadScene("Pve");
	 
	 
	}
	
	 public void ExtremeMode()
    {  audios.PlayOneShot(clip);
    playerSpeed=150f;
	 speed=500f;
	 tezina=3;
	 SceneManager.LoadScene("Pve");
	}
	
public void verSusButton()
{  audios.PlayOneShot(clip);
verSusPanel.SetActive(true);
 pveB.interactable=true;
difficultyPanel.SetActive(false);
optionsPanel.SetActive(false);
slider.SetActive(false);
}
	
	
	 public void verSUS()
    {  audios.PlayOneShot(clip);
    playerSpeed=200f;	 
	 SceneManager.LoadScene("Pvp");
	}
	
	public void exit()
	{  audios.PlayOneShot(clip);
	Application.Quit();
	}
	
public void options()
{
  audios.PlayOneShot(clip);
verSusPanel.SetActive(false);
difficultyPanel.SetActive(false);
optionsPanel.SetActive(true);
slider.SetActive(true);

}
   
   void Update(){
   if( ( optionsPanel.activeInHierarchy==true  ||  difficultyPanel.activeInHierarchy==true || verSusPanel.activeInHierarchy==true )&& Input.GetKeyDown(KeyCode.Escape))
   {
   difficultyPanel.SetActive(false);
   verSusPanel.SetActive(false);
   optionsPanel.SetActive(false);
   slider.SetActive(false);
   }
   
   
}//update

public void Fullscene(bool is_fullscene)
{
Screen.fullScreen=is_fullscene;
}

public void ChangeVolume()
{
AudioListener.volume=volumeSlider.value;
}


}
