using UnityEngine;
 
 public class MusicClass : MonoBehaviour
 {
     private AudioSource _audioSource;
      public GameObject music;
     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
          music=GameObject.FindWithTag("Music");
         _audioSource = music.GetComponent<AudioSource>();
     }
 
     public void PlayMusic()
     {
         if (_audioSource.isPlaying) return;
         _audioSource.Play();
     }
 
     public void StopMusic()
     {
         _audioSource.Stop();
     }
 }

