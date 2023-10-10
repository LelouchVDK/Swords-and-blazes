using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CowboyMovement : MonoBehaviour
{

    

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {     
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector2 right = new Vector2(100f, 0);
                rb.AddForce(right);
                
            }
            

                
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector2 left = new Vector2(-100f, 0);
                rb.AddForce(left);
            } 

                
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector2 up = new Vector2(0, 100f);
                rb.AddForce(up);
            }
                
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector2 down = new Vector2(0, -100f);
                rb.AddForce(down);
            }
        }
    }
