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

    public ParticleSystem blood2;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // If this object collides with an object with the tag "Cactus", this object takes damage.
        if (collision.gameObject.CompareTag("Cactus") || collision.gameObject.CompareTag("Knight"))
        {
            cowboyHealth.CowboyTakeDamage(10);
            BloodSplash2();
        }
    }

    void BloodSplash2()
    {
        blood2.Play();
    }


}
