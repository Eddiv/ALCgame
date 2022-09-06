using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jumpForce;
    public Rigidbody playerRB; 


    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)){
            playerRB.AddForce(Vector3.forward * jumpForce, ForceMode.Impulse);
        }
    }
}
