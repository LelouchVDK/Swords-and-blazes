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

    public ParticleSystem blood2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cactus"))
        {
            knightHealth.KnightTakeDamage(10);
            BloodSplash2();
        }
        
    }

    void BloodSplash2()
    {
        blood2.Play();
    }
}
