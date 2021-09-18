using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float gametime = 1.75f;
    // Start is called before the first frame update
    void Start()
    {
       StartGenerator(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    public void StartGenerator()
    {
        InvokeRepeating("createEnemy",0f,gametime);
    }

    public void StopGenerator()
    {
        CancelInvoke("createEnemy");
    }
}
