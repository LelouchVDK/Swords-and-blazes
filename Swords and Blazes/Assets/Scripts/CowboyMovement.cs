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

    public ParticleSystem dust;

    private Animator cowboyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        cowboyAnimator = GetComponent<Animator>();
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
            CreateDust();
        }
            


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 left = new(-m_cowboyMovementSpeed, 0);
            rb.AddForce(left);
            //transform.localScale = new Vector3(1, 1, 1);
            //FaceLeft = true;
            CreateDust();
        }

        


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 up = new(0, m_cowboyMovementSpeed);
            rb.AddForce(up);

            CreateDust();
        }
                
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 down = new(0, -m_cowboyMovementSpeed);
            rb.AddForce(down);

            CreateDust();
        }

        // The running animation.
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            cowboyAnimator.SetBool("cowboyRunning", true);
        }
        else { cowboyAnimator.SetBool("cowboyRunning", false); }

        // Dust trail 

        void CreateDust()
        {
            dust.Play();
        }

    }
}
