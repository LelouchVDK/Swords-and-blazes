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
    }

    // Update is called once per frame
    void Update()
    {
        switch (m_playerMovement) 
        { 
            case GravityDirection.Left:
                Physics2D.gravity = new Vector2(-10f, 0);
                if (Input.GetKeyDown(KeyCode.D))
                {
                    m_playerMovement = GravityDirection.Left;
                }
                break;

            case GravityDirection.Right:
                Physics2D.gravity = new Vector2(10f, 0);
                if (Input.GetKeyDown(KeyCode.A))
                {
                    m_playerMovement = GravityDirection.Right;
                }
                break;    

            case GravityDirection.Up:
                Physics2D.gravity = new Vector2(0, 10f);
                if (Input.GetKeyDown(KeyCode.W))
                {
                    m_playerMovement = GravityDirection.Up;
                }
                break;

            case GravityDirection.Down:
                Physics2D.gravity = new Vector2(0, -10f);
                if (Input.GetKeyDown(KeyCode.S))
                {
                    m_playerMovement = GravityDirection.Down;
                }
                break;
        }
    }

    
}
