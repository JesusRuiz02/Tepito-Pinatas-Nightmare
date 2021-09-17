using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector2 minimun;
    public Vector2 max;
    public float smoothed;
    Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x ,Player.transform.position.x, ref velocity.x, smoothed);
        float posY = Mathf.SmoothDamp(transform.position.y ,Player.transform.position.y, ref velocity.y, smoothed);
        transform.position = new Vector3(Mathf.Clamp(posX, minimun.x, max.x), Mathf.Clamp(posY, minimun.y, max.y),
            transform.position.z);
    }
    
}
