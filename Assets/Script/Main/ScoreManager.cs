using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager MyScoreManager;
    public int XScore = 0;
    public int OScore = 0;
    ScoreSetter myScoreSetter;
    // Start is called before the first frame update
    void Awake()
    {
      if (MyScoreManager != null && MyScoreManager != this)
      {
        Destroy(this.gameObject);
        return;
      }
      
      MyScoreManager = this;
      DontDestroyOnLoad(this);

       myScoreSetter = FindObjectOfType<ScoreSetter>();
    }
    
    public void XScorePlus()
    {
     XScore++;
    }

    public void OScorePlus()
    {
     OScore++;
    }

    public void ResetScore()
    {
      OScore = 0;
      XScore = 0;
    }
}
