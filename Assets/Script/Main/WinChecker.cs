using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinChecker : MonoBehaviour
{
    public Sprite XwinSprite;
    public Sprite OwinSprite;
    public string WinText;
    public Image MyWinImage;
    ScoreManager XmyScoreManager;
    bool scoreplus = true;
   


  void Start()
  {

      XmyScoreManager = FindObjectOfType<ScoreManager>();
     
  }

    // Update is called once per frame
    void Update()
    {
        if (WinText == "x")
        {
            MyWinImage.GetComponent<Image>().sprite = XwinSprite;
            if (scoreplus)
            {
                XmyScoreManager.XScorePlus();
                scoreplus = false;
            }
           
        }

        if (WinText == "o")
        {
            MyWinImage.GetComponent<Image>().sprite = OwinSprite;
            if (scoreplus)
            {
               XmyScoreManager.OScorePlus();
               scoreplus = false;
            }
            
        }
    }
}
