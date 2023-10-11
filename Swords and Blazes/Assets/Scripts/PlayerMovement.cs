using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    

    

    Rigidbody2D rb;
    public float m_knightMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 right = new Vector2(m_knightMovementSpeed, 0);
                rb.AddForce(right);
                
            }
        


        if (Input.GetKey(KeyCode.A))
            {
                Vector2 left = new Vector2(-m_knightMovementSpeed, 0);
                rb.AddForce(left);
                
            } 

                
            if (Input.GetKey(KeyCode.W))
            {
                Vector2 up = new Vector2(0, m_knightMovementSpeed);
                rb.AddForce(up);
                
            }
                
            if (Input.GetKey(KeyCode.S))
            {
                Vector2 down = new Vector2(0, -m_knightMovementSpeed);
                rb.AddForce(down);
                
            }
            
    }
    }
