using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KnightHealth : MonoBehaviour
{
    public int knightMaxHealth = 100;
    public int knightCurrentHealth;
    private AudioSource knightDeath;
    public TextMeshProUGUI winner;
    public GameObject opponent;
    public Rigidbody2D opponentRB;

    public KnightHealthBar knightHealthBar;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        opponentRB = GetComponent<Rigidbody2D>();
        knightCurrentHealth = knightMaxHealth;
        knightHealthBar.SetMaxHealth(knightMaxHealth);
        knightDeath = GetComponent<AudioSource>();
    }

    public void KnightTakeDamage(int amount)
    {
        knightCurrentHealth -= amount;

        knightHealthBar.SetHealth(knightCurrentHealth);

        

        if (knightCurrentHealth <= 0 ) 
        {
            knightDeath.Play();
            Destroy(gameObject);
            winner.text = "Winner is Cowboy";
            
            gameOverMenu.SetActive(true);
            opponentRB.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
