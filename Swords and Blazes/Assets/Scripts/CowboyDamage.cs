using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyDamage : MonoBehaviour
{
    public KnightHealth knightHealth;
    public CowboyHealth cowboyHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knight")
        {
            knightHealth.KnightTakeDamage(10);
        }
        if (collision.gameObject.tag == "Cactus")
        {
            cowboyHealth.CowboyTakeDamage(10);
        }
    }
}
