using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class KnightMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float m_knightMovementSpeed;
    [HideInInspector] public bool faceLeft;
    private Animator knightAnimator;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        knightAnimator = GetComponent<Animator>();
    }

    private void Update()
    {

        // The Knight attacks using the spacebar.
        if (Input.GetKey(KeyCode.Space))
        {
            knightAnimator.SetBool("Slash", true);
            Debug.Log("I'm Slashing!!!");
            
        }
        else
        {
            knightAnimator.SetBool("Slash", false);
        }

      
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 right = new Vector2(m_knightMovementSpeed, 0);
                rb.AddForce(right);
                transform.localScale = new Vector3(-1, 1, 1);
                faceLeft = false;
                // knightAnimator.SetBool("FaceLeftRight", true);
                


        }
        

            if (Input.GetKey(KeyCode.A))
            {
                Vector2 left = new Vector2(-m_knightMovementSpeed, 0);
                rb.AddForce(left);
                transform.localScale = new Vector3(1, 1, 1);
                faceLeft = true;
                // knightAnimator.SetBool("FaceLeftRight", true);


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
