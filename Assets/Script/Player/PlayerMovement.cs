using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator AC;
    public SpriteRenderer spriteRenderer;
    bool compro = false;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update() //Input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(movement.x>0)
        {
            compro = false;
            AC.SetBool("M_Left", true);
            spriteRenderer.flipX = true;
            AC.SetBool("M_Down", false);
            AC.SetBool("M_Up", false);
        }
        else if(movement.x<0)
        {
            compro = false;
            AC.SetBool("M_Left", true);
            spriteRenderer.flipX = false;
            AC.SetBool("M_Down", false);
            AC.SetBool("M_Up", false);
        }
        else
        {
            compro = true;
        }
        if(compro==true)
            {
            if (movement.y > 0)
            {
                AC.SetBool("M_Left", false);
                AC.SetBool("M_Up", true);
                AC.SetBool("M_Down", false);
            }
            else
            {
                AC.SetBool("M_Left", false);
                AC.SetBool("M_Up", false);
                AC.SetBool("M_Down", true);
            }
        }
        
    }
    //Ver orientacion para ataque

    


    void FixedUpdate() //Movement
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
    }
}