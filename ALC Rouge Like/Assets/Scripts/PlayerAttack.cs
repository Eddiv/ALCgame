using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay;
    private float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        if(attackDelay <=0)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Collider2d[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.positon, attackRange, whatIsEnemies);

                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }

            attackDelay = startDelay; 
        }
        else
        {
            attackDelay -= Time.deltaTime; //count down
        }
    }
    void OnDrawGizmosSelected() {
        
    }
        
    
}
