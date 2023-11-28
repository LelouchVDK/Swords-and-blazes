using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSlash : MonoBehaviour
{
    public CowboyHealth cowboyHealth;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cowboy"))
        {
            cowboyHealth.CowboyTakeDamage(10);
            Debug.Log("*IMPACT!*");
        }

    }

}
