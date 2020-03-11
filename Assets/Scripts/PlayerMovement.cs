using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static AudioSource sndSource;

    [SerializeField] private float _movementSpeed = 30f;
    float yRotation;
    float xRotation;


    void Start(){
        sndSource = GetComponent<AudioSource>();
    }
    protected void Update()
    {
        
        
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.6f)
        {
            transform.position -= _movementSpeed * Time.deltaTime * transform.forward * Input.GetAxis("Vertical");
        }
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.6f)
        {
            transform.position += _movementSpeed * Time.deltaTime * transform.right * Input.GetAxis("Horizontal");
        }
        if (Input.GetKey(KeyCode.Z)){
            transform.position += _movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position -= _movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.Q)){
            transform.position -= _movementSpeed * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += _movementSpeed * Time.deltaTime * transform.right;
        }
        
        
        transform.position = new Vector3(transform.position.x,7,transform.position.z);
    }

    public static void ding(){
        sndSource.Play();
    }
}
