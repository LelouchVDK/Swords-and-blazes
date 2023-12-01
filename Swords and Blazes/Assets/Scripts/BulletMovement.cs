using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    KnightDamage damage;
    Vector2 movement;
    public GameObject cowboy;
    public Transform playerPos;
    public Shoot shot;
    // Start is called before the first frame update
    void Start()
    {
        damage = FindAnyObjectByType<KnightDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
