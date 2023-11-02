using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyHealth : MonoBehaviour
{
    public int cowboyMaxHealth = 100;
    public int cowboyCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        cowboyCurrentHealth = cowboyMaxHealth;
    }


    void TakeDamage(int damage)
    {
        cowboyCurrentHealth -= damage;
    }
}
