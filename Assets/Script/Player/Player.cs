using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public bool onDeath = false;
    private int score = 0;
    private GameManager gameManager;
    private Lechuga lechuga;
    public GameObject canvas;
    public GameObject canvasLost;
    public Animator AC;
    Text instruction;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        canvas.SetActive(false);
        instruction = gameObject.GetComponent<Text>();
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
        if (score>=5)
        {
            FindObjectOfType<GameManager>().Ganaste();
            canvas.SetActive(true);
        }
        
        

    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            AC.SetBool("ded", true);
            AC.SetBool("Atack", false);
            AC.SetBool("M_Left", false);
            AC.SetBool("M_Up", false);
            AC.SetBool("M_Down", false);
            FindObjectOfType<GameManager>().GameOver();
            canvasLost.SetActive(true);

        }
    }
}
