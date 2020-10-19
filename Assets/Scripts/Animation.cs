using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite Knight1;
    public Sprite Knightwalk;
    public Sprite Knightjump;
    public Sprite Knightwalk2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Knight1;

        if (Input.GetKey("d"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>(); 
            spriteRenderer.sprite = Knightwalk;
        }

        if (Input.GetKey("a"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>(); 
            spriteRenderer.sprite = Knightwalk2;
        }

        if(Input.GetKey("space"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Knightjump;
        }
    }
}
