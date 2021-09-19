using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public bool onDeath = false;
    private int score = 0;
    private GameManager gameManager;
    private Lechuga lechuga;
    

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }

    private void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            TakeDamage(1);

        }

        if (collider.CompareTag("Point"))
        {
            scorePoint();
            collider.GetComponent<Lechuga>();
            Lechuga ingrediente = collider.GetComponent<Lechuga>();
            ingrediente.destroy();
            Debug.Log(score);
        }

    }

    void scorePoint()
    {
        score++;
        if (score>=3)
        {
            gameManager.Ganaste();
        }
        
        

    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
