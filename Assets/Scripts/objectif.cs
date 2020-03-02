using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectif : MonoBehaviour
{
    [SerializeField] private float objectiveTime = 2f;
    private float elapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other){
        if (other.tag == "ViewTrigger"){
            elapsed += Time.deltaTime;
            if (elapsed > objectiveTime)
            {
                ChangeObjectif();
            }
        }
    }

    void OnTriggerExit(Collider other){
        if (other.tag == "ViewTrigger"){
            elapsed = 0;
        }
    }
    
    void ChangeObjectif(){
        Debug.Log("GG");
    }
}
