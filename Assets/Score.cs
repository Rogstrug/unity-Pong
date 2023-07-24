using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

private TMP_Text textDisplay;
public GameObject ball;
Ball lopta;
public int scr;

   
    void Start()
    {
       textDisplay=GetComponent<TextMeshProUGUI>();
       scr=0;
       lopta=ball.GetComponent<Ball>();
        
    }
    
  
  void Update(){
  scr=lopta.score1;
  textDisplay.SetText(scr.ToString());
  }
  
}
