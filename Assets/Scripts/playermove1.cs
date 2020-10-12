using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class playermove1 : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        Vector2 Velocity = rb.velocity;
        if (Input.GetKey("space"))
        {
            Velocity.y = 12;
        }
 
        if (Input.GetKey("a"))
        {
            Velocity.x = -9;
        }
        if (Input.GetKey("d"))
        {
            Velocity.x = 9;
        }
        Velocity.y = -9;
        rb.velocity = Velocity;
    }
}
