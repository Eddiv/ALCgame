using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; //Score to give for the popped balloon.
    public int clickToPop = 3; //How many clicks before balloon pops
    public float scaleToIncrease = 0.10f; //Scale to increase each time the ballon is clicked

    //public ScoreManager scoreManager; // A variable to refrence the scoreManager
    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void OnMouseDown() {
        clickToPop -= 1;
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0) {
           // scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        };
    }
}
