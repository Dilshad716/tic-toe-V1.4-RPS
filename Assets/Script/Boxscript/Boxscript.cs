using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxscript : MonoBehaviour
{
    MainGameScript Mygamecontroller;
    MainGameScript myMainGameScript;
    public Image MyImage;
    public Sprite[] XSprite;
    public Sprite[] OSprite;
    [System.NonSerialized] public string BoxType;
    int OPowerlevel;
    [System.NonSerialized] public int XPowerlevel;
    ButtonUI MyButtonUI;
    public WinChecker MyWinChecker;
    public GameObject BoomPartical;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Mygamecontroller = FindObjectOfType<MainGameScript>();
        myMainGameScript = Mygamecontroller.GetComponent<MainGameScript>();
        MyButtonUI = FindObjectOfType<ButtonUI>();
        
      
    }

   
   public void Mouseclick()
   {
    
      
       if (myMainGameScript.PlayerTurn == 0)
       {
            
           XMove();
       }
       
       else
       {
            
          OMove();
          
       }
   
       
   }
 
  void X1(int XSpriteLevel) 
  {
    MyImage.GetComponent<Image>().color = new Color32 (255,255,255,255);
    MyImage.GetComponent<Image>().sprite = XSprite[XSpriteLevel];
    myMainGameScript.PlayerTurn = 1;
    BoxType = "x";
    
    

  }

  

  void O1(int OSpriteLevel) 
  {
    MyImage.GetComponent<Image>().color = new Color32 (255,255,255,255);
    MyImage.GetComponent<Image>().sprite = OSprite[OSpriteLevel];
    myMainGameScript.PlayerTurn = 0;
    BoxType = "o";
   

  }

  void XMoveSound()
  {
     if (MyButtonUI.XUIPowerLevel > OPowerlevel && BoxType != null )
     {
         GameObject myBoomPartical = Instantiate(BoomPartical,new Vector3(transform.position.x,transform.position.y,0),Quaternion.identity) as GameObject;
         FindObjectOfType<SoundManager>().PlaySound(7);
         Destroy(myBoomPartical,1f);
     }
     else
     {
         FindObjectOfType<SoundManager>().PlaySound(5);
     }

  }

  void OMoveSound()
  {
      if (MyButtonUI.OUIPowerLevel > XPowerlevel && BoxType != null )
      {
          GameObject myBoomPartical = Instantiate(BoomPartical,new Vector3(transform.position.x,transform.position.y,0),Quaternion.identity) as GameObject;
          FindObjectOfType<SoundManager>().PlaySound(7);
          Destroy(myBoomPartical,1f);
      }
      else
      {
          FindObjectOfType<SoundManager>().PlaySound(6);
      }

  }

  void ResetColor()
  {
    if (BoxType != null)
    {
        MyImage.GetComponent<Image>().color = new Color32 (255,255,255,255);
    }
    else
    {
        MyImage.GetComponent<Image>().color = new Color32 (255,255,255,0);
    }
    

  }

  void XMove()
  {
    if (BoxType == null || MyButtonUI.XUIPowerLevel > OPowerlevel && BoxType != "x")
    {
        if (MyButtonUI.XPowerCount[MyButtonUI.XUIPowerLevel] > 0)
        {
         XMoveSound();
         XPowerlevel = MyButtonUI.XUIPowerLevel;
         X1(XPowerlevel); 
         MyButtonUI.XPowerCount[XPowerlevel] --;
         MyButtonUI.XPowerText[XPowerlevel].text = MyButtonUI.XPowerCount[XPowerlevel].ToString();
         
        
         
        }
        else
        {
         WrongMove();
        }
            
    }

    else
    {
        WrongMove();
    }

  }
  

 void OMove()
  {
  if (BoxType == null || MyButtonUI.OUIPowerLevel > XPowerlevel && BoxType != "o")
   {
        if (MyButtonUI.OPowerCount[MyButtonUI.OUIPowerLevel] > 0)
        {
          OMoveSound();
          OPowerlevel = MyButtonUI.OUIPowerLevel;
          O1(OPowerlevel);
          MyButtonUI.OPowerCount[OPowerlevel] --;
          MyButtonUI.OPowerText[OPowerlevel].text = MyButtonUI.OPowerCount[OPowerlevel].ToString();
          
        }
        else
        {
          WrongMove();
        }
                 
  }
  else
  {
     WrongMove();
  }
  }

  void WrongMove()
  {
    FindObjectOfType<SoundManager>().PlaySound(1);
    MyImage.GetComponent<Image>().color = new Color32 (255,0,0,255);
    Invoke("ResetColor",0.1f); 

  }

}
