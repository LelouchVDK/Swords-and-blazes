using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHealth : MonoBehaviour
{
    public int knightMaxHealth = 100;
    public int knightCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        knightCurrentHealth = knightMaxHealth;
    }

    public void KnightTakeDamage(int amount)
    {
        knightCurrentHealth -= amount;
        if (knightCurrentHealth < 0 ) 
        {
            Destroy(gameObject);
        }
    }
}
