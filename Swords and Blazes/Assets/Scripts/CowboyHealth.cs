using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CowboyHealth : MonoBehaviour
{
    public int cowboyMaxHealth = 100;
    public int cowboyCurrentHealth;
    public AudioClip cowboyHit;
    public AudioClip cowboySwordHit;
    public AudioClip cowboyDeath;
    private AudioSource cowboyHitSound;
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
        cowboyHitSound = GetComponent<AudioSource>();
    }

    
    public void CowboyTakeDamage(int amount)
    {
        cowboyCurrentHealth -= amount;

        cowboyHealthBar.SetHealth(cowboyCurrentHealth);

        if (amount == 10)
        {
            cowboyHitSound.clip = cowboyHit;
            cowboyHitSound.Play();
        }
        else if (amount == 20) 
        {
            cowboyHitSound.clip = cowboySwordHit;
            cowboyHitSound.Play();
        }
        

        if (cowboyCurrentHealth <= 0)
        {
            cowboyHitSound.clip = cowboyDeath;
            GameObject.Find("SoundGuy").GetComponent<AudioSource>().PlayOneShot(cowboyDeath);

            cowboyHitSound.Play();

            gameObject.SetActive(false);
            winState.text = "Winner is Knight";
            gameOverMenu.SetActive(true);
            self.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
