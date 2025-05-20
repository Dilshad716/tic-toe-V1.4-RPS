using UnityEngine.Audio;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour
{
   public List <AudioClip> AudioList;
   public AudioSource myAudioSource;
   public static SoundManager MySoundManager;
   public AudioSource MainMusic;
   SoundSelecter MySoundSelecter;
   public bool PvCom = false;
   GameObject AiMove;

    void Awake()
   {
      if (MySoundManager != null && MySoundManager != this)
      {
          Destroy(this.gameObject);
          return;
      }
      MySoundManager = this;
      DontDestroyOnLoad(this);

      MySoundSelecter = FindObjectOfType<SoundSelecter>();
      AiMove = GameObject.FindWithTag("Ai");

    }
    private void Update()
    {
        
        
    }

    public void PlaySound(int SoundList)
   {
      
      myAudioSource.clip = AudioList[SoundList];
      myAudioSource.Play();
   }

  /* public void playeffectsound()
   {

     
      myAudioSource.clip = AudioList[1];
      myAudioSource.Play();

   }*/

   public void sounderror()
   {
      myAudioSource.clip = AudioList[1];
      myAudioSource.Play();
   }
    
    public void soundBack()
   {
      myAudioSource.clip = AudioList[3];
      myAudioSource.Play();
   }

     public void soundSelected()
   {
       myAudioSource.clip = AudioList[4];
   }

   public void PausemainMusic()
   {

   MySoundManager.MainMusic.Pause();

   }

   public void playemainMusic()
   {

   MySoundManager.MainMusic.Play();

   }

}
