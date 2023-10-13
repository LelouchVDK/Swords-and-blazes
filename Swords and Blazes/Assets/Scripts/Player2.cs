using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int maxHealth2 = 100;
    public int currentHealth2;

    public HealthBar2 healthBar2;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth2 = maxHealth2;
        healthBar2.SetMaxHealth(maxHealth2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            TakeDamage2(20);
        }
    }

    void TakeDamage2(int damage)
    {
        currentHealth2 -= damage;

        healthBar2.SetHealth(currentHealth2);
    }
}
