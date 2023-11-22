using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot.DelayDamage(bullet));
    }

    
}
