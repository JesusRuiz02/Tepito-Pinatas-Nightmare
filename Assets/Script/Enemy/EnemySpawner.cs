using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public float GeneratorSpeed = 5f;


    void Start()
    {
       
    }

     void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D collision)
     {
         ProcessCollisionSpawn(collision.gameObject);
     }

     private void OnTriggerExit2D(Collider2D collision)
     {
         if (collision.CompareTag("Player"))
         { 
             StopGenerator();
         }
        
     }

     private void ProcessCollisionSpawn(GameObject collider)
     {
         if (collider.CompareTag("Player"))
         {
             StartGenerator();
             
         }
        
     }
     void CreateEnemy()
     {
         Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
     }

     void StartGenerator()
     {
         InvokeRepeating("CreateEnemy",0f,GeneratorSpeed);
     }

     void StopGenerator()
     {
         CancelInvoke("CreateEnemy");
     }
}
