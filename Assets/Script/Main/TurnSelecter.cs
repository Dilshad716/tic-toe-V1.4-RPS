using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSelecter : MonoBehaviour
{
    [SerializeField] GameObject TurnRollbutton;
    [SerializeField] GameObject TurnPlaybutton;
    Image TurnSelecterSprite;
    [SerializeField] Sprite Xturnsprite;
    [SerializeField] Sprite Oturnsprite;
    public int spritechecker;
    
    [SerializeField] MainGameScript mainGameScript;
    int FixTurn;
    Animator myanimator;

    void Start()
    {
        TurnSelecterSprite = GameObject.FindWithTag("TurnSelectTag").GetComponent<Image>();
        myanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spritechecker == 1)
        {
            TurnSelecterSprite.sprite = Xturnsprite;
        }
        if (spritechecker == 2)
        {
            TurnSelecterSprite.sprite = Oturnsprite;
        }
        //roll();
        FixTurn = Random.Range(1, 3);

    }

    public void TurnRoll()
    {
      
        StartCoroutine("StartRoll");
        TurnRollbutton.GetComponent<Button>().interactable = false;

    }

    public void StartGame()
    {

        mainGameScript.GetComponent<MainGameScript>().hasStarted = true;
        myanimator.SetBool("TurnSelect",true);
    }


    IEnumerator Roll()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.15f);
            spritechecker = 1;
            yield return new WaitForSeconds(0.15f);
            spritechecker = 2;
           
        }
       

        
        
    }

    IEnumerator StartRoll()
    {
        StartCoroutine("Roll");
        yield return new WaitForSeconds(2);
        StopCoroutine("Roll");
        StopCoroutine("StartRoll");
        TurnRollbutton.SetActive(false);
        TurnPlaybutton.SetActive(true);
        mainGameScript.GetComponent<MainGameScript>().PlayerTurn = FixTurn -1;
        spritechecker = FixTurn;

    }
}
