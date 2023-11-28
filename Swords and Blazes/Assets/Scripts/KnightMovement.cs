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

    public delegate void HitAction();
    public event HitAction OnHitAction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        knightAnimator = GetComponent<Animator>();
    }

    private void Update()
    {

        // The Knight attacks using the spacebar.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            knightAnimator.SetBool("Slash", true);
            OnHitAction?.Invoke();
            
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            knightAnimator.SetBool("Slash", false);
        }

      
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 right = new(m_knightMovementSpeed, 0);
                rb.AddForce(right);
                transform.localScale = new Vector3(-1, 1, 1);
                faceLeft = false;
                // knightAnimator.SetBool("FaceLeftRight", true);
                


        }
        

            if (Input.GetKey(KeyCode.A))
            {
                Vector2 left = new(-m_knightMovementSpeed, 0);
                rb.AddForce(left);
                transform.localScale = new Vector3(1, 1, 1);
                faceLeft = true;
                // knightAnimator.SetBool("FaceLeftRight", true);


        } 

                
            if (Input.GetKey(KeyCode.W))
            {
                Vector2 up = new(0, m_knightMovementSpeed);
                rb.AddForce(up);
                
            }
                
            if (Input.GetKey(KeyCode.S))
            {
                Vector2 down = new(0, -m_knightMovementSpeed);
                rb.AddForce(down);
                
            }


    }
}
