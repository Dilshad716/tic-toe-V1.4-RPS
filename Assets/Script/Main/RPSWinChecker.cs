using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSWinChecker : MonoBehaviour
{
    [SerializeField] Sprite Red;
    [SerializeField] Sprite Blue;
    [SerializeField] Image WinSpriteText;
    public string winner;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (winner == "Red")
        {
            WinSpriteText.sprite = Red;
        }
        if (winner == "Blue")
        {
            WinSpriteText.sprite = Blue;
        }

    }
}
