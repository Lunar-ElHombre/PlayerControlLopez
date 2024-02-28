using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 20.0f;
    private float HorizontalInput;
    private float turnSpeed = 45.0f;
    private float forwardInput;
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the car forward based on vertical
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Roates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * HorizontalInput * Time.deltaTime);
    }
}
