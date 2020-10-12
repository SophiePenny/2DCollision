using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    int timer;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        direction = 2;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer ++;
        //Debug.Log(timer);
        rb.velocity = new Vector2(direction, 0);
        if (timer > 200)
        {
            direction = -direction;
            timer = 0;
        }
    }
}



