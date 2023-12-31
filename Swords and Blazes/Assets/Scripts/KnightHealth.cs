using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

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
    public CowboyMovement noMove;

    public ParticleSystem blood1;
    private CinemachineImpulseSource impulseSource;

    public KnightHealthBar knightHealthBar;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        opponentRB = GetComponent<Rigidbody2D>();
        knightCurrentHealth = knightMaxHealth;
        knightHealthBar.SetMaxHealth(knightMaxHealth);
        knightSound = GetComponent<AudioSource>();
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public void KnightTakeDamage(int amount)
    {
        knightCurrentHealth -= amount;

        CamaraShakeManager.instance.CameraShake(impulseSource);

        knightHealthBar.SetHealth(knightCurrentHealth);

        knightSound.clip = knightHurt;
        knightSound.Play();

        BloodSplash1();

        if (knightCurrentHealth <= 0 ) 
        {
            knightSound.clip = knightDeath;
            GameObject.Find("SoundGuy").GetComponent<AudioSource>().PlayOneShot(knightDeath);
            noMove.m_cowboyMovementSpeed = 0;
            knightSound.Play();
            gameObject.SetActive(false);
            winner.text = "Winner is Cowboy";

            BloodSplash1();

            gameOverMenu.SetActive(true);
            //opponentRB.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }

    void BloodSplash1()
    {
        blood1.Play();
    }

}
