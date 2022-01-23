using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private bool scaleInput;
    private Vector3 playerSize;
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        scaleInput = Input.GetKey(KeyCode.Space);
        transform.Rotate(Vector3.right * Time.deltaTime * speed * verticalInput);        
        transform.Rotate(Vector3.forward, turnSpeed * horizontalInput * Time.deltaTime);
        playerSize = transform.localScale;

        if (scaleInput)
        {
            transform.localScale = transform.localScale + new Vector3(.01f, .01f, .01f);   
            


        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }
}
