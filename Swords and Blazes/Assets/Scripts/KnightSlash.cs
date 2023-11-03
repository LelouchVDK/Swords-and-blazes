using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSlash : MonoBehaviour
{
    // Creating a gameobject variable for the hitbox.
    public GameObject hitbox;
    private Vector3 direction = Vector3.left;
    

    private void FixedUpdate()
    {
        Attack();
    }

    void Attack()
    {
        /* If the knight player pressed down a directional button & the attack button
        they instantiate a hitbox. */

        /* if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.Space)))
        {
            Instantiate(hitbox, new Vector3(-1,0,0), Quaternion.identity);
            Debug.Log("I'm swinging my sword!!!");
        } */

        // ^^ Disabled for now to try out some other code.

       // RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 5.5f);



      
    }

}
