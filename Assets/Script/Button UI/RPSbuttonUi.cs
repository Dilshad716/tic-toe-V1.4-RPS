using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RPSbuttonUi : MonoBehaviour
{
    [SerializeField] GameObject[] RedUI;
    [SerializeField] GameObject[] BlueUI;
    Button[] RedUIbutton = new Button[3];
    Button[] BlueUIbutton = new Button[3];
    [System.NonSerialized] public object[] RedactiveBoxname = new object[2];
    [System.NonSerialized] public object[] BlueactiveBoxname = new object[2];
    [SerializeField] public TMP_Text[] RedUiCountText;
    [SerializeField] public TMP_Text[] BlueUiCountText;
    public int[] RedUiCount =  new int[3];
    public int[] BlueUiCount = new int[3];
    [SerializeField] gameController mygameController;
    [SerializeField] GameObject[] Glow;
    [SerializeField] GameObject PauseWindow;
    SoundManager soundManager;


    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
        RedactiveBoxname[0] = 0;
        RedactiveBoxname[1] = "RedRock";
        BlueactiveBoxname[0] = 0;
        BlueactiveBoxname[1] = "BlueRock";


        for (int i = 0; i < RedUI.Length; i++)
        {
            RedUIbutton[i] = RedUI[i].GetComponent<Button>();
            BlueUIbutton[i] = BlueUI[i].GetComponent<Button>();
            RedUiCount[i] = 3; BlueUiCount[i] = 3;
            RedUiCountText[i].text = RedUiCount[i].ToString();
            BlueUiCountText[i].text = BlueUiCount[i].ToString();
        }
        RedUIbutton[0].interactable = false;
        BlueUIbutton[0].interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mygameController.Playerturn == 0)
        {
            Glow[1].SetActive(false);
            Glow[0].SetActive(true);
        }
        else
        {
            
            Glow[1].SetActive(true);
            Glow[0].SetActive(false);
        }
    }

    public void RedRockActive()
    {

        for (int i = 0; i < RedUIbutton.Length; i++)
        {
            RedUIbutton[i].interactable = true;
        }
        RedUIbutton[0].interactable = false;
        RedactiveBoxname[0] = 0;
        RedactiveBoxname[1] = "RedRock";
        soundManager.PlaySound(2);
    }

    public void RedPapperActive()
    {

        for (int i = 0; i < RedUIbutton.Length; i++)
        {
            RedUIbutton[i].interactable = true;
        }
        RedUIbutton[1].interactable = false;
        RedactiveBoxname[0] = 1;
        RedactiveBoxname[1] = "RedPapper";
        soundManager.PlaySound(2);
    }

    public void RedSciccorActive()
    {

        for (int i = 0; i < RedUIbutton.Length; i++)
        {
            RedUIbutton[i].interactable = true;
        }
        RedUIbutton[2].interactable = false;
        RedactiveBoxname[0] = 2;
        RedactiveBoxname[1] = "RedSciccor";
        soundManager.PlaySound(2);
    }
    // blue
    public void BlueRockActive()
    {

        for (int i = 0; i < BlueUIbutton.Length; i++)
        {
            BlueUIbutton[i].interactable = true;
        }
        BlueUIbutton[0].interactable = false;
        BlueactiveBoxname[0] = 0;
        BlueactiveBoxname[1] = "BlueRock";
        soundManager.PlaySound(2);
    }

    public void BluePapperActive()
    {

        for (int i = 0; i < BlueUIbutton.Length; i++)
        {
            BlueUIbutton[i].interactable = true;
        }
        BlueUIbutton[1].interactable = false;
        BlueactiveBoxname[0] = 1;
        BlueactiveBoxname[1] = "BluePapper";
        soundManager.PlaySound(2);
    }

    public void BlueSciccorActive()
    {

        for (int i = 0; i < BlueUIbutton.Length; i++)
        {
            BlueUIbutton[i].interactable = true;
        }
        BlueUIbutton[2].interactable = false;
        BlueactiveBoxname[0] = 2;
        BlueactiveBoxname[1] = "BlueSciccor";
        soundManager.PlaySound(2);

    }

    // Ui Buttons

    public void PauseWindowActive()
    {
        PauseWindow.SetActive(true);
        soundManager.PlaySound(8);

    }

    public void ResumeWindowActive()
    {
        PauseWindow.SetActive(false);
        soundManager.PlaySound(9);

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
        soundManager.PlaySound(0);

    }

    public void Back()
    {
        SceneManager.LoadScene(0);
        soundManager.PlaySound(4);

    }

    public void RestartWindowActive()
    {
        SceneManager.LoadScene(2);
        soundManager.PlaySound(0);

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        soundManager.PlaySound(0);

    }

}
