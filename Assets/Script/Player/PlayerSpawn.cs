using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject Players;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Players);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
