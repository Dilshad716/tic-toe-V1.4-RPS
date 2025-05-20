using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameScript : MonoBehaviour
{
    public GameObject[] BoxList;
    public int PlayerTurn = 0; // 0 =x and 1 = 0 ;
    string[] CheckBoxType;
    public GameObject XGlowCircle;
    public GameObject OGlowCircle;
    public Animator WinAnim;
    public int WinCheckForAi = 0;
    public bool hasStarted = false;
    public WinChecker winChecker;
    [SerializeField] GameObject aiMove;

    void Awake()
    {  
         CheckBoxType = new string[BoxList.Length];

        

    }

   
    void Update()
    {
         for (int i = 0; i <= BoxList.Length - 1; i++)
         {
          CheckBoxType[i] = BoxList[i].GetComponent<Boxscript>().BoxType;
         }

         GlowCircle();
        win();

    }

    
  
    public void win()
    {
        if (CheckBoxType[0] == CheckBoxType[1] && CheckBoxType[1] == CheckBoxType[2] && CheckBoxType[2] == CheckBoxType[0] && CheckBoxType[0] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[0]; aiMove.SetActive(false); } 
        
        else if (CheckBoxType[3] == CheckBoxType[4] && CheckBoxType[4] == CheckBoxType[5] && CheckBoxType[5] == CheckBoxType[3] && CheckBoxType[3] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[3]; aiMove.SetActive(false); } 
       
        else if (CheckBoxType[6] == CheckBoxType[7] && CheckBoxType[7] == CheckBoxType[8] && CheckBoxType[8] == CheckBoxType[6] && CheckBoxType[6] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[6]; aiMove.SetActive(false); } 
        
        else if (CheckBoxType[0] == CheckBoxType[3] && CheckBoxType[3] == CheckBoxType[6] && CheckBoxType[6] == CheckBoxType[0] && CheckBoxType[0] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[0]; aiMove.SetActive(false); } 
        
        else if (CheckBoxType[1] == CheckBoxType[4] && CheckBoxType[4] == CheckBoxType[7] && CheckBoxType[7] == CheckBoxType[1] && CheckBoxType[1] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[1]; aiMove.SetActive(false); } 
       
        else if (CheckBoxType[2] == CheckBoxType[5] && CheckBoxType[5] == CheckBoxType[8] && CheckBoxType[8] == CheckBoxType[2] && CheckBoxType[2] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[2]; aiMove.SetActive(false); } 
       
        else if (CheckBoxType[0] == CheckBoxType[4] && CheckBoxType[4] == CheckBoxType[8] && CheckBoxType[8] == CheckBoxType[0] && CheckBoxType[0] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[0]; aiMove.SetActive(false); } 
       
        else if (CheckBoxType[2] == CheckBoxType[4] && CheckBoxType[4] == CheckBoxType[6] && CheckBoxType[6] == CheckBoxType[2] && CheckBoxType[2] != null)
        {WinAnim.GetComponent<Animator>().SetTrigger("WinTrigger"); WinCheckForAi = 1; winChecker.WinText = CheckBoxType[2]; aiMove.SetActive(false); } 

    }

void GlowCircle()
  {
   
   if (PlayerTurn ==0)
    {
      XGlowCircle.SetActive(true);
      OGlowCircle.SetActive(false);
    }
   else
    {
      XGlowCircle.SetActive(false);
      OGlowCircle.SetActive(true);
    }

  }


   
}
