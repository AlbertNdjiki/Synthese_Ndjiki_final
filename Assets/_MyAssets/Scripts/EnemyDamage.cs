using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyDamage : MonoBehaviour
{


    private int pointage=0;
    public int health = 100;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0){
            Score.scoreValue += 1;
            pointage++;
            Die();
        }
        
    }

    void Die()
    {
       
        Destroy(gameObject);
    }

   
    
}
