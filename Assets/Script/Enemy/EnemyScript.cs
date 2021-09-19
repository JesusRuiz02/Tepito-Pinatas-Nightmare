using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public AIPath aiPath;
    public Animator AC;

    public SpriteRenderer spriteRenderer;
    bool compro = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if ( aiPath.desiredVelocity.x> 0)
        {
            compro = false;
            AC.SetBool("M_Left", true);
            spriteRenderer.flipX = true;
            AC.SetBool("M_Down", false);
            AC.SetBool("M_Up", false);
        }
        else if (aiPath.desiredVelocity.x < 0)
        {
            compro = false;
            AC.SetBool("M_Left", true);
            AC.SetBool("M_Down", false);
            AC.SetBool("M_Up", false);
        }
        else
        {
            compro = true;
        }
        if (compro == true)
        {
            if (aiPath.desiredVelocity.y > 0)
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
}
