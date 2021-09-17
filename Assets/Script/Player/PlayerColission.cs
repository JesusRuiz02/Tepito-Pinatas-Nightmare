using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColission : MonoBehaviour
{
    public int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        
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
            LostLife();

        }

    }

    private void LostLife()
    {
        life--;

        if (life <= 0)
        {
            Debug.Log("Perdiste");
        }
        
    }
}
