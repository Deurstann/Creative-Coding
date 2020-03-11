using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public static float finalscore;
    
    Text textedScore;
    // Start is called before the first frame update
    void Start()
    {
        textedScore = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textedScore.text = ""+finalscore;
        Debug.Log(textedScore.text);
    }
}
