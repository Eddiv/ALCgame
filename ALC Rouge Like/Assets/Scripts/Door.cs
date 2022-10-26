using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm;
    public Sprite doorOpen;
    public Sprite doorClosed;
    private SpriteRenderer spriteR;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            this.enabled = false;
            gm.key --;
            Debug.Log("You have used a Key. You have "+ gm.key +"s" );
            spriteR.sprite = doorOpen;
            Debug.Log("Door is open!");
        }
        else
        {
            Debug.Log("Door is locked. You need a key");
        }
    }
    
        
    
}
