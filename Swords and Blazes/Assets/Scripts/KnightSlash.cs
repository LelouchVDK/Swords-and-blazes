using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSlash : MonoBehaviour
{
    public CowboyHealth cowboyHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cowboy")
        {
            cowboyHealth.CowboyTakeDamage(10);
        }

    }

}
