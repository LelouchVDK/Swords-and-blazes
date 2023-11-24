using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Shoot shoot;


    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, 0.5f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Knight"))
        {
            KnightHealth knightHealth = collision.gameObject.GetComponent<KnightHealth>();
            knightHealth.KnightTakeDamage(20);
            
        }
        Destroy(gameObject, 0.5f);
    }


}
