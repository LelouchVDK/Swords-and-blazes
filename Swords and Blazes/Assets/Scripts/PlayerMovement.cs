using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    enum GravityDirection
    {
        Down,
        Left,
        Right,
        Up
    }

    GravityDirection m_playerMovement;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        m_playerMovement = GravityDirection.Down;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {     
            if (Input.GetKeyDown(KeyCode.D))
            {
                Physics2D.gravity = new Vector2(10f, 0);
                m_playerMovement = GravityDirection.Right;
            }
            

                
            if (Input.GetKeyDown(KeyCode.A))
            {
                Physics2D.gravity = new Vector2(-10f, 0);
                m_playerMovement = GravityDirection.Left;
            } 

                
            if (Input.GetKeyDown(KeyCode.W))
            {
                Physics2D.gravity = new Vector2(0, 10f);
                m_playerMovement = GravityDirection.Up;
            }
                
            if (Input.GetKeyDown(KeyCode.S))
            {
                Physics2D.gravity = new Vector2(0, -10f);
                m_playerMovement = GravityDirection.Down;
            }
        }
    }
