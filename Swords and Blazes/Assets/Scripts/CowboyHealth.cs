using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CowboyHealth : MonoBehaviour
{
    public int cowboyMaxHealth = 100;
    public int cowboyCurrentHealth;
    public TextMeshProUGUI winState;
    public GameObject opponent;
    public Rigidbody2D self;

    public CowboyHealthBar cowboyHealthBar;
    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Rigidbody2D>();
        cowboyCurrentHealth = cowboyMaxHealth;
        cowboyHealthBar.SetMaxHealth(cowboyMaxHealth);
    }

    
    public void CowboyTakeDamage(int amount)
    {
        cowboyCurrentHealth -= amount;

        cowboyHealthBar.SetHealth(cowboyCurrentHealth);


        if (cowboyCurrentHealth <= 0)
        {
            Destroy(gameObject);
            winState.text = "Winner is Knight";
            gameOverMenu.SetActive(true);
            self.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
