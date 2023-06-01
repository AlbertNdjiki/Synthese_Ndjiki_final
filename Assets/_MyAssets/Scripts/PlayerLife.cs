using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
   
    public int maxhealth = 4;
    public int currenthealth;
    [SerializeField] private AudioSource deathSoundEffect;

    public GameObject limiteHaut;
    public GameObject limiteBas;

    private Vector3 haut;
    private Vector3 bas;

    private Vector2 input;

    public HealthBar health;

   private void Start()
    {
        currenthealth = maxhealth;
        health.SetMaxHealth(maxhealth);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        haut = limiteHaut.transform.position;
        bas = limiteBas.transform.position;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pieges"))
        {
            TakeDamage(1);
        }
    }

    

    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        health.SetHealth(currenthealth);

        if (currenthealth <= 0)
        {
            Die();
        }

    }

    private void FixedUpdate()
    {
        
        if (transform.position.x <= bas.x || transform.position.x >= haut.x)
        {
            Die();
            Respawn();
        }

        if (transform.position.y <= bas.y || transform.position.y >= haut.y)
        {
            Die();
            Respawn();
        }
    }


}
