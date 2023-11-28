using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{

    private System.Random rand = new System.Random();
    SpawnCoin spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("CoinSpawner").GetComponent<SpawnCoin>();
    }

    // Update is called once per frame
    void Update()
    {

    }

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

            //StartCoroutine (Respawn(collision,6));
            spawner.SpawnCoins();

        }
    }

} 
