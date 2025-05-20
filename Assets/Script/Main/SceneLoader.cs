using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   ScoreManager MyScoreManager;
   

   void Awake()
   {
        MyScoreManager = FindObjectOfType<ScoreManager>();
       
   }
   public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void PvCom()
    {

        FindObjectOfType<SoundManager>().PvCom = true;

        SceneManager.LoadScene(1);

        if (MyScoreManager != null)
        {
            MyScoreManager.ResetScore();
        }
        else
        {
            return;
        }

        
    }

    public void PvP3x3Scene()
    {
        FindObjectOfType<SoundManager>().PvCom = false;
        SceneManager.LoadScene(1);
        
        if (MyScoreManager != null)
        {
            MyScoreManager.ResetScore();
        }
        else
        {
        return;
        }
        
    }
    public void PlayAgain()
    {
      SceneManager.LoadScene(1); 
    }

    public void Quit()
    {
     Application.Quit();
    }

    public void RpsMode()
    {
        SceneManager.LoadScene(2);

    }
}
