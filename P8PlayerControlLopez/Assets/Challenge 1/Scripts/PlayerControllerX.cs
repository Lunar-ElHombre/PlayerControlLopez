using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float HorizontalInput;
    private float rotationSpeed = 65.0f;
    private float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        //Move the car forward based on vertical
        transform.Translate(Vector3.forward * speed * Time.deltaTime * HorizontalInput);
        // Roates the car based on horizontal input
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * VerticalInput);
    }
}
