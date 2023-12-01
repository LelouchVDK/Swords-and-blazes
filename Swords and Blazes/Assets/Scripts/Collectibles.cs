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

            if (coins == 5) winnerText.text = "Winner is " + winner.tag;

            //StartCoroutine (Respawn(collision,6));
            spawner.SpawnCoins();

            
        }
    }

} 
