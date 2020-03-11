
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class textDéroulant : MonoBehaviour
{
    public float delay = 2f;
    private float actualDelay;

    [Multiline(15)]
    public string fullText;
    
    private string currentText = "";

    // Start is called before the first frame update
    void Start()
    {
        actualDelay = delay;
        StartCoroutine(ShowText());
    }

    void Update(){
        if (Input.GetKey(KeyCode.Return)||Input.GetKey("joystick button 0")) {
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator ShowText(){
        for (int i = 0; i < fullText.Length+1;i++){
            currentText = fullText.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(actualDelay);
        }
    }
}
