using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightDamage : MonoBehaviour
{
    public CowboyHealth cowboyHealth;
    public KnightHealth knightHealth;
    // Start is called before the first frame update
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cowboy"))
        {
            cowboyHealth.CowboyTakeDamage(10);
        }
        if (collision.gameObject.CompareTag("Cactus"))
        {
            knightHealth.KnightTakeDamage(10);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            knightHealth.KnightTakeDamage(20);
        }
    }
}
