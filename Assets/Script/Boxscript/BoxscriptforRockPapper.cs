using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxscriptforRockPapper : MonoBehaviour
{
    [SerializeField] Sprite[] BlueSprite;
    [SerializeField] Sprite[] RedSprite;
    [SerializeField] Image myBoxImage;
    [System.NonSerialized] public string BoxType;
    [SerializeField] gameController mygameController;
    [SerializeField] string RedBoxName;
    [SerializeField] string BlueBoxName;
    RPSbuttonUi rPSbuttonUi;
    SoundManager soundManager;
    [SerializeField] GameObject StepOverBoom;

    void Start()
    {
        rPSbuttonUi = FindObjectOfType<RPSbuttonUi>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    
    public void OnmouseClick()
    {
        if (mygameController.Playerturn == 0)
        {
            if (BoxType == null && rPSbuttonUi.BlueUiCount[(int)rPSbuttonUi.BlueactiveBoxname[0]] > 0 || BoxType == "Red" && rPSbuttonUi.BlueUiCount[(int)rPSbuttonUi.BlueactiveBoxname[0]] > 0)
            {

                if (RedBoxName == "RedRock" && (string)rPSbuttonUi.BlueactiveBoxname[1] == "BluePapper"
                 || RedBoxName == "RedPapper" && (string)rPSbuttonUi.BlueactiveBoxname[1] == "BlueSciccor"
                 || RedBoxName == "RedSciccor" && (string)rPSbuttonUi.BlueactiveBoxname[1] == "BlueRock")

                {
                    BlueTurn();
                    soundManager.PlaySound(7);
                    GameObject BoomPartical = Instantiate(StepOverBoom, new Vector3(transform.position.x, transform.position.y,0), Quaternion.identity) as GameObject;
                    Destroy(BoomPartical, 1f);
                }
                if (BoxType == null)
                {
                    BlueTurn();
                    soundManager.PlaySound(5);
                }

            }

            else
            {
                WrongMove();
            }
        }
        else
        {
            if (BoxType == null && rPSbuttonUi.RedUiCount[(int)rPSbuttonUi.RedactiveBoxname[0]] > 0 || BoxType == "Blue" && rPSbuttonUi.RedUiCount[(int)rPSbuttonUi.RedactiveBoxname[0]] > 0)
            {
                if (BlueBoxName == "BlueRock" && (string)rPSbuttonUi.RedactiveBoxname[1] == "RedPapper"
                || BlueBoxName == "BluePapper" && (string)rPSbuttonUi.RedactiveBoxname[1] == "RedSciccor"
                || BlueBoxName == "BlueSciccor" && (string)rPSbuttonUi.RedactiveBoxname[1] == "RedRock")
                {
                    RedTurn();
                    soundManager.PlaySound(7);
                    GameObject BoomPartical = Instantiate(StepOverBoom, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
                    Destroy(BoomPartical, 1f);
                }
                if (BoxType == null)
                {
                    RedTurn();
                    soundManager.PlaySound(6);
                }

            }

            else
            {
                WrongMove();
            }
        }
        

    }

    void BlueTurn()
    {
     myBoxImage.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
     myBoxImage.GetComponent<Image>().sprite = BlueSprite[(int)rPSbuttonUi.BlueactiveBoxname[0]];
     mygameController.Playerturn = 1;
     BoxType = "Blue";
     rPSbuttonUi.BlueUiCount[(int)rPSbuttonUi.BlueactiveBoxname[0]]--;
     rPSbuttonUi.BlueUiCountText[(int)rPSbuttonUi.BlueactiveBoxname[0]].text = rPSbuttonUi.BlueUiCount[(int)rPSbuttonUi.BlueactiveBoxname[0]].ToString();
     BlueBoxName = (string)rPSbuttonUi.BlueactiveBoxname[1];    
    }

    void RedTurn()
    {
     myBoxImage.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
     myBoxImage.GetComponent<Image>().sprite = RedSprite[(int)rPSbuttonUi.RedactiveBoxname[0]];
     mygameController.Playerturn = 0;
     BoxType = "Red";
     rPSbuttonUi.RedUiCount[(int)rPSbuttonUi.RedactiveBoxname[0]]--;
     rPSbuttonUi.RedUiCountText[(int)rPSbuttonUi.RedactiveBoxname[0]].text = rPSbuttonUi.RedUiCount[(int)rPSbuttonUi.RedactiveBoxname[0]].ToString();
     RedBoxName = (string)rPSbuttonUi.RedactiveBoxname[1];
    }

    void WrongMove()
    {
        soundManager.PlaySound(1);
        myBoxImage.GetComponent<Image>().color = new Color32(255, 0, 0, 180);
        Invoke("ResetColor", 0.1f);

    }

    void ResetColor()
    {
        if (BoxType != null)
        {
            myBoxImage.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            myBoxImage.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }


    }
}
