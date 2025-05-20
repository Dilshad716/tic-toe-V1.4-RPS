using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public int Playerturn; // 0 = red, 1= blue
    [SerializeField] BoxscriptforRockPapper[] boxscriptforRockPapper;
    string[] CheckBoxtype;
    [SerializeField] RPSWinChecker rPSWinChecker;
    [SerializeField] GameObject GameObjectrPSWinChecker;
    void Start()
    {
        CheckBoxtype = new string[boxscriptforRockPapper.Length];
        Playerturn = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < boxscriptforRockPapper.Length; i++)
        {
            CheckBoxtype[i] = boxscriptforRockPapper[i].GetComponent<BoxscriptforRockPapper>().BoxType;
        }

        win();
       // print(CheckBoxtype[2]);
    }
    void win()
    {

        if (CheckBoxtype[0] == CheckBoxtype[1] && CheckBoxtype[1] == CheckBoxtype[2] && CheckBoxtype[2] == CheckBoxtype[0] && CheckBoxtype[0] != null)
        {
            print("Win1");
            rPSWinChecker.winner = CheckBoxtype[0];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[3] == CheckBoxtype[4] && CheckBoxtype[4] == CheckBoxtype[5] && CheckBoxtype[5] == CheckBoxtype[3] && CheckBoxtype[3] != null)
        {
            print("Win2");
            rPSWinChecker.winner = CheckBoxtype[3];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[6] == CheckBoxtype[7] && CheckBoxtype[7] == CheckBoxtype[8] && CheckBoxtype[8] == CheckBoxtype[6] && CheckBoxtype[6] != null)
        {
            print("Win3");
            rPSWinChecker.winner = CheckBoxtype[6];
            GameObjectrPSWinChecker.SetActive(true);
        }

        if (CheckBoxtype[0] == CheckBoxtype[3] && CheckBoxtype[3] == CheckBoxtype[6] && CheckBoxtype[6] == CheckBoxtype[0] && CheckBoxtype[0] != null)
        {
            print("Win4");
            rPSWinChecker.winner = CheckBoxtype[0];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[1] == CheckBoxtype[4] && CheckBoxtype[4] == CheckBoxtype[7] && CheckBoxtype[7] == CheckBoxtype[1] && CheckBoxtype[1] != null)
        {
            print("Win5");
            rPSWinChecker.winner = CheckBoxtype[1];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[2] == CheckBoxtype[5] && CheckBoxtype[5] == CheckBoxtype[8] && CheckBoxtype[8] == CheckBoxtype[2] && CheckBoxtype[2] != null)
        {
            print("Win6");
            rPSWinChecker.winner = CheckBoxtype[2];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[0] == CheckBoxtype[4] && CheckBoxtype[4] == CheckBoxtype[8] && CheckBoxtype[8] == CheckBoxtype[0] && CheckBoxtype[0] != null)
        {
            print("Win7");
            rPSWinChecker.winner = CheckBoxtype[0];
            GameObjectrPSWinChecker.SetActive(true);
        }
        if (CheckBoxtype[2] == CheckBoxtype[4] && CheckBoxtype[4] == CheckBoxtype[6] && CheckBoxtype[6] == CheckBoxtype[2] && CheckBoxtype[2] != null)
        {
            print("Win8");
            rPSWinChecker.winner = CheckBoxtype[2];
            GameObjectrPSWinChecker.SetActive(true);
        }
    }
}
