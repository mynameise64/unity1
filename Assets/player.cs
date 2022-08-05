using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float walkSpeed = 5;
    public float mouseSensitivity;
    public static bool holdingBall = true;
    public static float bowlSpeed = 5;
    public static Vector3 direction;
    Rigidbody rb;
    public static float rotX;
    public static float rotY;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
         float mouseY = -Input.GetAxis("Mouse Y");
        // direction = transform.forward;
        if (Input.GetKey("w")) {
            // rb.AddRelativeForce(transform.forward * walkSpeed);
            //.AddRelativeForce(Vector3.forward*walkSpeed);
            transform.position += transform.forward * walkSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s")) {
            // GetComponent<Rigidbody>().AddRelativeForce(-transform.forward*walkSpeed);
             transform.position -= transform.forward * walkSpeed * Time.deltaTime;
    }
        
        if (Input.GetKey("a")) {
            transform.position -= transform.right * walkSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d")) {
            transform.position += transform.right * walkSpeed * Time.deltaTime;
        }
        rotY += mouseX * mouseSensitivity;
         rotX += mouseY * mouseSensitivity;
 
         //rotX = Mathf.Clamp(rotX, -90, 90);
        transform.rotation = Quaternion.Euler(transform.rotation.x,rotY,transform.rotation.z); 
        //GameObject.Find("Main Camera").transform.rotation = Quaternion.Euler(rotX,transform.rotation.y,transform.rotation.z);
        //print(direction);
    }
}

