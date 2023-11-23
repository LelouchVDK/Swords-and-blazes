using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Shoot shoot;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shoot.DelayDamage(bullet));
    }

    
}
