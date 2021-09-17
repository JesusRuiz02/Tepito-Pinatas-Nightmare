using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10;

    public Vector3 screensize;

    private void Start()
    {
         screensize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
    }


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(speed * Time.deltaTime,0);
        detection();

       
    }

    private void detection()
    {
       
        if (gameObject.transform.position.x >= screensize.x + 5 )
        {
            Destroy(this.gameObject);
        }
        if (gameObject.transform.position.x <= screensize.x - 5 )
        {
            Destroy(this.gameObject);
        }
        
        if (gameObject.transform.position.y >= screensize.y + 5 )
        {
            Destroy(this.gameObject);
        }
        if (gameObject.transform.position.x >= screensize.y - 5 )
        {
            Destroy(this.gameObject);
        }
    }
}
