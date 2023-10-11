using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    

    

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
            if (Input.GetKeyDown(KeyCode.D))
            {
                Vector2 right = new Vector2(100f, 0);
                rb.AddForce(right);
                
            }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            rb.AddForce(-rb.velocity);
        }


        if (Input.GetKeyDown(KeyCode.A))
            {
                Vector2 left = new Vector2(-100f, 0);
                rb.AddForce(left);
                
            } 

                
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector2 up = new Vector2(0, 100f);
                rb.AddForce(up);
                
            }
                
            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector2 down = new Vector2(0, -100f);
                rb.AddForce(down);
                
            }
            
    }
    }
