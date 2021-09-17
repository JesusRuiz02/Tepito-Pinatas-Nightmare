using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;//El objeto que es el jugador
    public Vector2 minimun;//Las coordenadas minimos a la que llegara la camara
    public Vector2 max;//Las coordenadas maximas a la que llegara la camara
    public float smoothed;//El tiempo en que llegara la camara
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
