using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiMove : MonoBehaviour
{
    [SerializeField] GameObject[] AiBoxlist;
    [SerializeField] GameObject[] AiOButtonsGameObject;
    Button[] AiOButtons;
    MainGameScript myMainGameScript;
    string[] BoxTypeForAi;
    int[] XpowerLevelForAi;
    int AimoveInt;
    ButtonUI mybuttonUI;
    int UiActiveCount;
    bool UiActiveBool = false;
    [SerializeField] GameObject myAiMove;
    [SerializeField] GameObject OUiBlockImage;
    



    // Start is called before the first frame update
    void Start()
    {
        mybuttonUI = FindObjectOfType<ButtonUI>();

        BoxTypeForAi = new string[AiBoxlist.Length];
        XpowerLevelForAi = new int[AiBoxlist.Length];
        AiOButtons = new Button[AiOButtonsGameObject.Length];
        myMainGameScript = FindObjectOfType<MainGameScript>();
        AimoveInt = -1;
        for (int i = 0; i < AiOButtonsGameObject.Length; i++)
        {
            AiOButtons[i] = AiOButtonsGameObject[i].GetComponent<Button>();
        }


        if (!FindObjectOfType<SoundManager>().PvCom)
        {
            myAiMove.SetActive(false);
            OUiBlockImage.SetActive(false);
        }
        else
        {
            myAiMove.SetActive(true);
            OUiBlockImage.SetActive(true);
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {

        for (int i = 0; i < AiBoxlist.Length; i++)
        {
            BoxTypeForAi[i] = AiBoxlist[i].GetComponent<Boxscript>().BoxType;
        }
        for (int i = 0; i < AiBoxlist.Length; i++)
        {
            XpowerLevelForAi[i] = AiBoxlist[i].GetComponent<Boxscript>().XPowerlevel;
        }

        if (myMainGameScript.PlayerTurn == 1 && myMainGameScript.WinCheckForAi == 0 && myMainGameScript.hasStarted)
        {

            if (AimoveInt > -1)
            {

                if (BoxTypeForAi[AimoveInt] != "o" && BoxTypeForAi[AimoveInt] != "x")
                {
                    UiActiveCount = Random.Range(0, 4);
                    UiActiveBool = true;
                    AiBoxlist[AimoveInt].GetComponent<Boxscript>().Mouseclick();
                }
                else
                {
                    if (BoxTypeForAi[AimoveInt] == "x" && XpowerLevelForAi[AimoveInt] < 2)
                    {
                        UiActiveCount = Random.Range(0, 4);
                        UiActiveBool = true;
                        AiBoxlist[AimoveInt].GetComponent<Boxscript>().Mouseclick();
                        

                    }
                    else
                    {
                        AimoveInt = Random.Range(0, 8);
                      
                    }
                    
                    
                }

                

            }
            else
            {
                AimoveInt = Random.Range(0, 8);

            }

            
           



        }

        AiAttackMove();
        AiDefenceMove();
        
        Uiactivater();


    }



    void Uiactivater()
    {
        if (UiActiveCount == 0 && UiActiveBool)
        {
            mybuttonUI.O1active();
            UiActiveBool = false;
        }
        else if (UiActiveCount == 1 && UiActiveBool)
        {
            mybuttonUI.O2active();
            UiActiveBool = false;
        }
        else if (UiActiveCount == 2 && UiActiveBool)
        {
            mybuttonUI.O3active();
            UiActiveBool = false;
        }
        else if (UiActiveCount == 3 && UiActiveBool)
        {
            mybuttonUI.O4active();
            UiActiveBool = false;
        }

    }

    void AiDefenceMove()
    {
        // 0
        if (BoxTypeForAi[1] == "x" && BoxTypeForAi[2] == "x" && BoxTypeForAi[0] != "o" || BoxTypeForAi[3] == "x" && BoxTypeForAi[6] == "x" && BoxTypeForAi[0] != "o" || BoxTypeForAi[4] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[0] != "o")
        {
            AimoveInt = 0;
        }

        // 1
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[2] == "x" && BoxTypeForAi[1] != "o" || BoxTypeForAi[4] == "x" && BoxTypeForAi[7] == "x" && BoxTypeForAi[1] != "o")
        {
            AimoveInt = 1;

        }

        // 2
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[1] == "x" && BoxTypeForAi[2] != "o" || BoxTypeForAi[4] == "x" && BoxTypeForAi[6] == "x" && BoxTypeForAi[2] != "o" || BoxTypeForAi[5] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[2] != "o")

        {
            AimoveInt = 2;
        }

        // 3
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[6] == "x" && BoxTypeForAi[3] != "o" || BoxTypeForAi[4] == "x" && BoxTypeForAi[5] == "x" && BoxTypeForAi[3] != "o")

        {
            AimoveInt = 3;

        }

        // 4
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[4] != "o" || BoxTypeForAi[2] == "x" && BoxTypeForAi[6] == "x" && BoxTypeForAi[4] != "o" || BoxTypeForAi[1] == "x" && BoxTypeForAi[7] == "x" && BoxTypeForAi[4] != "o" || BoxTypeForAi[3] == "x" && BoxTypeForAi[5] == "x" && BoxTypeForAi[4] != "o")

        {
            AimoveInt = 4;
        }

        // 5
        if (BoxTypeForAi[2] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[5] != "o" || BoxTypeForAi[3] == "x" && BoxTypeForAi[4] == "x" && BoxTypeForAi[5] != "o")

        {
            AimoveInt = 5;
        }

        // 6
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[3] == "x" && BoxTypeForAi[6] != "o" || BoxTypeForAi[7] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[6] != "o" || BoxTypeForAi[4] == "x" && BoxTypeForAi[2] == "x" && BoxTypeForAi[6] != "o")

        {
            AimoveInt = 6;
        }

        // 7
        if (BoxTypeForAi[1] == "x" && BoxTypeForAi[4] == "x" && BoxTypeForAi[7] != "o" || BoxTypeForAi[6] == "x" && BoxTypeForAi[8] == "x" && BoxTypeForAi[7] != "o")

        {
            AimoveInt = 7;
        }

        // 8
        if (BoxTypeForAi[0] == "x" && BoxTypeForAi[4] == "x" && BoxTypeForAi[8] != "o" || BoxTypeForAi[2] == "x" && BoxTypeForAi[5] == "x" && BoxTypeForAi[8] != "o" || BoxTypeForAi[6] == "x" && BoxTypeForAi[7] == "x" && BoxTypeForAi[8] != "o")

        {
            AimoveInt = 8;
        }



    }


    void AiAttackMove()
    {
        // 0
        if (BoxTypeForAi[1] == "o" && BoxTypeForAi[2] == "o" || BoxTypeForAi[3] == "o" && BoxTypeForAi[6] == "o" || BoxTypeForAi[4] == "o" && BoxTypeForAi[8] == "o")
        {
            if (BoxTypeForAi[0] != "x")
            {
                AimoveInt = 0;

            } 
        }

        // 1
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[2] == "o"  || BoxTypeForAi[4] == "o" && BoxTypeForAi[7] == "o")
        {
            
            if (BoxTypeForAi[1] != "x")
            {
                AimoveInt = 1;

            }
        }

        // 2
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[1] == "o" || BoxTypeForAi[4] == "o" && BoxTypeForAi[6] == "o" || BoxTypeForAi[5] == "o" && BoxTypeForAi[8] == "o")

        {
            if (BoxTypeForAi[2] != "x")
            {
                AimoveInt = 2;
            }
            
        }

        // 3
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[6] == "o"|| BoxTypeForAi[4] == "o" && BoxTypeForAi[5] == "o")

        {
            
            if (BoxTypeForAi[3] != "x")
            {
                AimoveInt = 3;

            }
        }

        // 4
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[8] == "o"  || BoxTypeForAi[2] == "o" && BoxTypeForAi[6] == "o"  || BoxTypeForAi[1] == "o" && BoxTypeForAi[7] == "o" || BoxTypeForAi[3] == "o" && BoxTypeForAi[5] == "o" )

        {
            
            if (BoxTypeForAi[4] != "x")
            {
                AimoveInt = 4;

            }
        }

        // 5
        if (BoxTypeForAi[2] == "o" && BoxTypeForAi[8] == "o" || BoxTypeForAi[3] == "o" && BoxTypeForAi[4] == "o")

        {
            
            if (BoxTypeForAi[5] != "x")
            {
                AimoveInt = 5;

            }
        }

        // 6
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[3] == "o" || BoxTypeForAi[7] == "o" && BoxTypeForAi[8] == "o"|| BoxTypeForAi[4] == "o" && BoxTypeForAi[2] == "o" )

        {
            
            if (BoxTypeForAi[6] != "x")
            {
                AimoveInt = 6;

            }
        }

        // 7
        if (BoxTypeForAi[1] == "o" && BoxTypeForAi[4] == "o"|| BoxTypeForAi[6] == "o" && BoxTypeForAi[8] == "o" )

        {
            
            if (BoxTypeForAi[7] != "x")
            {
                AimoveInt = 7;

            }
        }

        // 8
        if (BoxTypeForAi[0] == "o" && BoxTypeForAi[4] == "o" || BoxTypeForAi[2] == "o" && BoxTypeForAi[5] == "o"|| BoxTypeForAi[6] == "o" && BoxTypeForAi[7] == "o" )

        {
           
            if (BoxTypeForAi[8] != "x")
            {
                AimoveInt = 8;

            }
        }



    }



}
