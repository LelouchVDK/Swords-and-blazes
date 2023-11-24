using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Shoot shoot;

    /// <summary>
    /// Waits a while before making bullet disappear
    /// </summary>
    public IEnumerator DelayDamage()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Knight"))
        {
            KnightHealth knightHealth = collision.gameObject.GetComponent<KnightHealth>();
            knightHealth.KnightTakeDamage(20);
            StartCoroutine(DelayDamage());
        }
    }


}
