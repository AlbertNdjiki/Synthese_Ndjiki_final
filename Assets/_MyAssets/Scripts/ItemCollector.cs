using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class ItemCollector : MonoBehaviour
{
    private int Oranges = 0;

    public HealthBar health;

    public int maxhealth = 4;
    public int currenthealth;

    [SerializeField] private AudioSource collectionSoundEffect;

    




     void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Orange"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            GainLife(1);
            
        }
       else if (collision.gameObject.CompareTag("Pomme"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Oranges+=2;
          
        }

      
    }

    public void GainLife(int life)
    {
        currenthealth += life;

        health.SetHealth(currenthealth);

        if (currenthealth >= 4)
        {
            health.SetHealth(maxhealth);
        }

    }
    public int GetOranges()
    {
        return Oranges;
    }
}
