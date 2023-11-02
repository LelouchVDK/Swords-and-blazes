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

    void KnightDamage(int damage)
    {
        knightCurrentHealth -= damage;
    }
}
