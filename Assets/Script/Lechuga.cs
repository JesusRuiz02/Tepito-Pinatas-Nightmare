using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lechuga : MonoBehaviour
{
    public GameObject ingrediente;
    // Start is called before the first frame update
    public void destroy()
    {
        Destroy(this.gameObject);
    }
}
