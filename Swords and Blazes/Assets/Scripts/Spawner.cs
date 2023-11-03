using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    //public bool stopSpawning = false;
    //public float spawnTime;
    //public float spawnDelay;
    public Vector2 rand;


    //public GameObject coinPrefab;
    //public GameObject previousCoin;
    //public GameObject cowboy;
    //public GameObject knight;
    //[Range(0f, 25f)]

    //public float xRange = 8;

   // public float yRange = 5;






    
    void Start()
    {

        

        Instantiate(objectToSpawn, rand, transform.rotation);
        //float randomFloat = Random.Range(-1, 1);
    }


    
    
       
   
    
    // Update is called once per frame


    private void Update()
    {
        //if (previousCoin.transform.position.x - cowboy.transform.position.x < 1)

        rand = new Vector2(Random.Range(-12, 12), Random.Range(-8, 8));
        //Vector3 newPosition = previousCoin.transform.position + new Vector3(20 + Random.Range(-8, 8), Random.Range(-5f, 5f), 0);

        // previousCoin = Instantiate(coinPrefab, newPosition, Quaternion.identity); 


    }
     


}