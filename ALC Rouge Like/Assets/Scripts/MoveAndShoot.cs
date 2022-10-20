using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDistance;
    private Transform target;
    private float shortDelay;
    public float startDelay;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shortDelay = startDelay;

    }

    // Update is called once per frame
    void Update()
    {
         if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);  //Move Towards Target
        } else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance) 
            {
                transform.position = this.transform.position; //Dont Move
            } else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime); //Move Away From Target
                }

        // Ranged Attack
        if(shortDelay <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);//Fire Projectile
        } else 
            {
                shortDelay -= Time.deltaTime;
            }
    }
}