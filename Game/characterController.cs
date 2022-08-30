using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;


    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.forward * Speed * vInput * Time.deltaTime);

    }
}
