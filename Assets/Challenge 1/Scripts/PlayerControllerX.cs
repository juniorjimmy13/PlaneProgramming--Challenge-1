﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input 
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate changed to forward
        transform.Translate(Vector3.forward * speed*Time.fixedDeltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * (verticalInput*100) * Time.deltaTime);
    }
}
