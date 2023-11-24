using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// How Knight does or takes damage. 
/// Takes damage when hit by a cactus.
/// Does damage when colliding
/// </summary>
public class KnightDamage : MonoBehaviour
{
    public CowboyHealth cowboyHealth;
    public KnightHealth knightHealth;
    public GameObject bullet;
    

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
        
    }
}
