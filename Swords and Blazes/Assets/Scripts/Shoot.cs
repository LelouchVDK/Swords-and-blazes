using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public GameObject cowboy;
    public Vector2 mouse_pos = Input.mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shootingPoint.position,transform.rotation);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(cowboy.transform.position, mouse_pos);

    }
}