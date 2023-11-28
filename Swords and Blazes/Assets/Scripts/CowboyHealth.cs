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

    public CowboyHealthBar cowboyHealthBar;

    // Start is called before the first frame update
    void Start()
    {
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
            Application.Quit();
        }
    }
}
