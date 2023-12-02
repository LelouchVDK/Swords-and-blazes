using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CowboyMovement : MonoBehaviour
{
    // public bool FaceLeft { get; private set; } = true;
    

    Rigidbody2D rb;
    public float m_cowboyMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 right = new (m_cowboyMovementSpeed, 0);
            rb.AddForce(right);
            //transform.localScale = new Vector3(-1, 1, 1);
            //FaceLeft = false;

        }
            


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 left = new(-m_cowboyMovementSpeed, 0);
            rb.AddForce(left);
            //transform.localScale = new Vector3(1, 1, 1);
            //FaceLeft = true;
        }

        


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 up = new(0, m_cowboyMovementSpeed);
            rb.AddForce(up);
        }
                
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 down = new(0, -m_cowboyMovementSpeed);
            rb.AddForce(down);
        }
    }
}
