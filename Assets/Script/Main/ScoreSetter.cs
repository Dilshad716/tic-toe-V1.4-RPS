using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreSetter : MonoBehaviour
{
    public GameObject XScoreObject;
    public GameObject OScoreObject;
    public TextMeshProUGUI XScoretex;
    TextMeshProUGUI OScoretex;

    
    // Start is called before the first frame update
    void Start()
    {
        XScoreObject = GameObject.FindWithTag("XScoreTex");
        OScoreObject = GameObject.FindWithTag("OScoreTex");
        XScoretex    = XScoreObject.GetComponent<TMPro.TextMeshProUGUI>();
        OScoretex    = OScoreObject.GetComponent<TMPro.TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        XScoretex.text = FindObjectOfType<ScoreManager>().XScore.ToString();
        OScoretex.text = FindObjectOfType<ScoreManager>().OScore.ToString();
    }
}
