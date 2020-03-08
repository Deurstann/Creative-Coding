using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _movementSpeed = 30f;
    float yRotation;
    float xRotation;

    [SerializeField] private float lookSensitivity = 2;
    float currentXRotation;
    float currentYRotation;
    float yRotationV;
    float xRotationV;
    float lookSmoothnes = 0.1f; 
    protected void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * lookSensitivity;
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 100);
        currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationV, lookSmoothnes);
        currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationV, lookSmoothnes);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += _movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= _movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += _movementSpeed * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= _movementSpeed * Time.deltaTime * transform.right;
        }
        
        transform.position = new Vector3(transform.position.x,7,transform.position.z);
    }
}
