using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPreFabs; //Array to store the game object
        public float startDelay = 0.5f;
        public float spawnInterval = 1.5f;
        public float xRange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay. SpawnInterval); //Continuosly spawns balloons with a start delay and interval delay
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        //get random positon on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),0,0);

        //pick a randon ballon from the ballon array
        int balloonIndex = Random.Range(0,balloonPreFabs.Length);

        //spawn random balloon at spawn positon
        Instantiate(balloonPreFabs[balloonIndex], spawnPos, balloonPreFabs[balloonIndex].transform.rotation); 
    }
}
