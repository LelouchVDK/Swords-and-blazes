using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KnightHealth : MonoBehaviour
{
    public int knightMaxHealth = 100;
    public int knightCurrentHealth;
    public AudioClip knightHurt;
    public AudioClip knightDeath;
    private AudioSource knightSound;
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
        knightSound = GetComponent<AudioSource>();
    }

    public void KnightTakeDamage(int amount)
    {
        knightCurrentHealth -= amount;

        knightHealthBar.SetHealth(knightCurrentHealth);

        knightSound.clip = knightHurt;
        knightSound.Play();

        if (knightCurrentHealth <= 0 ) 
        {
            knightSound.clip = knightDeath;
            knightSound.Play();
            gameObject.SetActive(false);
            winner.text = "Winner is Cowboy";
            
            gameOverMenu.SetActive(true);
            opponentRB.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
