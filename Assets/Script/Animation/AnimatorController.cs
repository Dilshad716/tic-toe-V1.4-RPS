using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    public Animator anim;
    public Animator WinAnim;
    
    
    
 
 public void PauseWindow()
 {

     anim.GetComponent<Animator>().SetTrigger("PauseIn");
 }

 public void ResumeWindow()
 {

     anim.GetComponent<Animator>().SetTrigger("ResumeOut");
 }

 

 

    


}
