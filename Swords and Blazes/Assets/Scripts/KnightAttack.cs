using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Attack();
        }
    }

    void Attack()
    {
      Collider2D[] hitEnemies = Physics2D OverlapCircleAll(attackPoint.position, attackRange, gameObject.CompareTag("Knight")); 
    }

}
