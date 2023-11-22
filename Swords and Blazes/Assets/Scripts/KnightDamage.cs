using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (collision.gameObject.CompareTag("Bullet"))
        {
            print("Hello there");
            knightHealth.KnightTakeDamage(20);
            Vector2 screen_pos = Input.mousePosition;
            Vector2 world_pos = Camera.main.ScreenToWorldPoint(screen_pos);
            // Coroutine shoot = StartCoroutine(Shoot.DelayDamage(Shoot.Instantiate(bullet, world_pos, Quaternion.identity)));
            
        }
    }
}
