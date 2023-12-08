using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboySounds : MonoBehaviour
{

    private AudioSource cowboyShoot;
    // Start is called before the first frame update
    void Start()
    {
        cowboyShoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            cowboyShoot.Play();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            cowboyShoot.Stop();
        }
    }
}
