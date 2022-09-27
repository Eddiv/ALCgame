using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Speed
    public float speed;
    private float hInput;
    private float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.translate(Vector2.up * vInput * speed * Time.deltaTime); //Move up or down
        transform.translate(Vector2.right * hInput * speed * Time.deltaTime); // Move left or right

    }
}
