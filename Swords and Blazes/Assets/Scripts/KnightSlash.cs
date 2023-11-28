using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSlash : MonoBehaviour
{
    public CowboyHealth cowboyHealth;
    public Animator knightAnimator;

    private bool cowboyInRange = false;

    private void Start()
    {
        FindAnyObjectByType<KnightMovement>().OnHitAction += KnightSlash_onHitAction;
    }

    private void KnightSlash_onHitAction()
    {
        if(cowboyInRange)
        {
            cowboyHealth.CowboyTakeDamage(20);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cowboy") /*&& knightAnimator.GetBool("Slash")*/)
        {
            cowboyInRange = true;
            Debug.Log("*IMPACT!*");
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cowboy") /*&& knightAnimator.GetBool("Slash")*/)
        {
            cowboyInRange = false;
        }
    }

}
