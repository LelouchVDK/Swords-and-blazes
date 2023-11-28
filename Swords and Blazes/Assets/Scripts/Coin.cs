using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
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



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag is "Knight" or "Cowboy")
        {
            Destroy(gameObject);
            spawner.SpawnCoins();
        }


    }



}
