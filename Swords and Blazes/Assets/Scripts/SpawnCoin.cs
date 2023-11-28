using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField]
    private GameObject Coins;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCoins(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnCoins()
    {
        bool coinsSpawned = false;
        while (!coinsSpawned)
        {
         Vector3 coinPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);

           
            
            
            
            if ((coinPosition - transform.position).magnitude < 3)
            {
               continue;
            }

            else
            {
                Instantiate(Coins, coinPosition, Quaternion.identity);
                coinsSpawned = true;
            }
        }

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SpawnCoins();
    }
}

