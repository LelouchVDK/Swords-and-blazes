using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectibles : MonoBehaviour
{

    SpawnCoin spawner;
    public TextMeshProUGUI winnerText;
    public GameObject winner;
    public GameObject GameOverMenu;
    public KnightMovement noKnightMove;
    public CowboyMovement noCowboyMove;
    
    

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("CoinSpawner").GetComponent<SpawnCoin>();
    }

    // Update is called once per frame
    

    //IEnumerator Respawn (Collider2D collision, int time)
    //{
       // yield return new WaitForSeconds(time);

        //collision.gameObject.SetActive(true);
    //} 


    private int coins = 0;
    [SerializeField] private Text CoinCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);
            
            
            //Destroy(collision.gameObject);//
            coins++;
            CoinCounter.text = "Coins " + coins;

            if (coins == 5)
            {
                winnerText.text = "Winner is " + winner.tag;
                GameOverMenu.SetActive(true);
                if (winner.CompareTag("Knight"))
                {
                    noKnightMove.m_knightMovementSpeed = 0;
                }
                if (winner.CompareTag("Cowboy"))
                {
                    noCowboyMove.m_cowboyMovementSpeed = 0;
                }

            }

            //StartCoroutine (Respawn(collision,6));
            spawner.SpawnCoins();

            
        }
    }

} 
