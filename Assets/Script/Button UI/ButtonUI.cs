using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonUI : MonoBehaviour
{
    public GameObject[] XUI;
    public GameObject[] OUI;
    Button[] MyXButtons = new Button[5];
    Button[] MyOButtons = new Button[5];
    [System.NonSerialized] public int XUIPowerLevel;
    [System.NonSerialized] public int OUIPowerLevel;
    public TMP_Text[] XPowerText;
    public TMP_Text[] OPowerText;
    [System.NonSerialized] public int[] XPowerCount = new int[4];
    [System.NonSerialized] public int[] OPowerCount = new int[4];
    SoundManager MySoundManager;
        void Awake()
    {
        XPowerCount[0] = 3;
        XPowerCount[1] = 3;
        XPowerCount[2] = 2;
        XPowerCount[3] = 1;
        OPowerCount[0] = 3;
        OPowerCount[1] = 3;
        OPowerCount[2] = 2;
        OPowerCount[3] = 1;



        for (int i = 0; i < XUI.Length; i++)
        {
             MyXButtons[i] = XUI[i].GetComponent<Button>();
             MyOButtons[i] = OUI[i].GetComponent<Button>();
             XPowerText[i].text = XPowerCount[i].ToString();
             OPowerText[i].text = OPowerCount[i].ToString();
        }
       
        XUI[0].GetComponent<Button>().interactable = false;
        OUI[0].GetComponent<Button>().interactable = false;
        //XUI[0].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
        //OUI[0].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
        MySoundManager = FindObjectOfType<SoundManager>();
        
            
    }
    
    // X Active Methods
public void X1active()
    {
         
        for (int i = 0; i < XUI.Length; i++)
        {
            MyXButtons[i].interactable = true;
            //XUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyXButtons[0].interactable = false;
           // XUI[0].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            XUIPowerLevel = 0;
            MySoundManager.PlaySound(2);
        
    }
   
public void X2active()
    {

      for (int i = 0; i < XUI.Length; i++)
        {
            MyXButtons[i].interactable = true;
           // XUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyXButtons[1].interactable = false;
           // XUI[1].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            XUIPowerLevel = 1;
            MySoundManager.PlaySound(2);
           
    }



public void X3active()
    {

       for (int i = 0; i < XUI.Length; i++)
        {
            MyXButtons[i].interactable = true;
           // XUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyXButtons[2].interactable = false;
          //  XUI[2].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            XUIPowerLevel = 2;
            MySoundManager.PlaySound(2);
    }


public void X4active()
    {

        for (int i = 0; i < XUI.Length; i++)
        {
            MyXButtons[i].interactable = true;
            //XUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyXButtons[3].interactable = false;
           // XUI[3].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            XUIPowerLevel = 3;
            MySoundManager.PlaySound(2);
    }
// O Active Methods

public void O1active()
    {

        for (int i = 0; i < OUI.Length; i++)
        {
            MyOButtons[i].interactable = true;
          //  OUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyOButtons[0].interactable = false;
          //  OUI[0].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            OUIPowerLevel = 0;
            MySoundManager.PlaySound(2);
    }
   
public void O2active()
    {

      for (int i = 0; i < OUI.Length; i++)
        {
            MyOButtons[i].interactable = true;
          //  OUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyOButtons[1].interactable = false;
           // OUI[1].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            OUIPowerLevel = 1;
            MySoundManager.PlaySound(2);
    }



public void O3active()
    {

       for (int i = 0; i < OUI.Length; i++)
        {
            MyOButtons[i].interactable = true;
            //OUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyOButtons[2].interactable = false;
           // OUI[2].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            OUIPowerLevel = 2;
            MySoundManager.PlaySound(2);
    }


public void O4active()
    {

        for (int i = 0; i < OUI.Length; i++)
        {
            MyOButtons[i].interactable = true;
          //  OUI[i].GetComponent<RectTransform>().sizeDelta = new Vector2(140,140);
        }
            MyOButtons[3].interactable = false;
           // OUI[3].GetComponent<RectTransform>().sizeDelta = new Vector2(160,160);
            OUIPowerLevel = 3;
            MySoundManager.PlaySound(2);
    }

}
