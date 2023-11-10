using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KnightHealth : MonoBehaviour
{
    public int knightMaxHealth = 100;
    public int knightCurrentHealth;
    public TextMeshProUGUI winner;
    public GameObject opponent;

    public KnightHealthBar knightHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        knightCurrentHealth = knightMaxHealth;
        knightHealthBar.SetMaxHealth(knightMaxHealth);
    }

    public void KnightTakeDamage(int amount)
    {
        knightCurrentHealth -= amount;

        knightHealthBar.SetHealth(knightCurrentHealth);

        if (knightCurrentHealth < 0 ) 
        {
            Destroy(gameObject);
            winner.text = "Winner is Cowboy";
        }
    }
}
