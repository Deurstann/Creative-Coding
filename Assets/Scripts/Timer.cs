using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float remainingTime;
    private float maxTime = 30f;

    private Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = maxTime;
        image = this.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        if (remainingTime < 0.0001f) remainingTime = 0.0001f;
        Color curColor = image.color;
        curColor.a = Mathf.Max(0.1f,remainingTime/maxTime);
        image.color = curColor;

    }
}
