using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSounds : MonoBehaviour
{
    private AudioSource knightSlash;
    // Start is called before the first frame update
    void Start()
    {
        knightSlash = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            knightSlash.Play();
        }
    }
}
