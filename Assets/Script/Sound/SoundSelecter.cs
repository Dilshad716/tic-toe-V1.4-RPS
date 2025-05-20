using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSelecter : MonoBehaviour
{
   public int MySoundSelecter;
   SoundManager MySoundManager;
   public Sprite Offmusic;
   public Sprite Onmusic;
   public GameObject MyMusic;
   


   void Start()

   {

        MySoundManager = FindObjectOfType<SoundManager>();
       
   }

   public int SoundReturn()
   {
     
     return MySoundSelecter;

   }

   public void playeffectsound()
   {

     
    MySoundManager.myAudioSource.clip = MySoundManager.AudioList[MySoundSelecter];
    MySoundManager.myAudioSource.Play();

   }

   public void PausemainMusic()
   {

   MySoundManager.MainMusic.Pause();

   }

   public void playemainMusic()
   {

   MySoundManager.MainMusic.Play();

   }

   public void ToggleMusic(bool musictoggle)

   {
      
      
      if (!musictoggle)
      {
         MySoundManager.MainMusic.Pause();
         MyMusic.GetComponent<Image>().sprite = Onmusic;

      }
      else
      {
          MySoundManager.MainMusic.Play();
          
          MyMusic.GetComponent<Image>().sprite = Offmusic;
      }
     
   }

   
}
