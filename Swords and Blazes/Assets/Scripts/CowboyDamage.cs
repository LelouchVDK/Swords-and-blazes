using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// How Cowboy does or takes damage. 
/// Takes damage when hit by a cactus.
/// Does damage when colliding
/// </summary>
public class CowboyDamage : MonoBehaviour
{
    public KnightHealth knightHealth;
    public CowboyHealth cowboyHealth;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Knight"))
        {
            knightHealth.KnightTakeDamage(10);
        }
        if (collision.gameObject.CompareTag("Cactus"))
        {
            cowboyHealth.CowboyTakeDamage(10);
        }
    }
}
