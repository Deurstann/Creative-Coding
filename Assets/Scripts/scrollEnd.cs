using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollEnd : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * scrollSpeed * new Vector3(0f,1f,0f);
    }
}
