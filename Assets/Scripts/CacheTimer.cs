using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacheTimer : MonoBehaviour
{
    public static float remaining;
    private float max = 30f;
    // Start is called before the first frame update
    void Start()
    {
        remaining = max;
    }

    // Update is called once per frame
    void Update()
    {
        remaining -= Time.deltaTime;
        if (remaining < 0.0001f) remaining = 0.0001f;
        transform.localScale = new Vector3(Mathf.Max(0.1f,1-remaining/max),transform.localScale.y,transform.localScale.z); 
    }
}
