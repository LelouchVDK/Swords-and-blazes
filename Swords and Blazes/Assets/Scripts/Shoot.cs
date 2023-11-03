using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public GameObject cowboy;
    public LineRenderer render;
    public Vector2 offset;
    public CowboyMovement faceDir;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 mouse_pos = Input.mousePosition;
        CowboyMovement faceDir = cowboy.GetComponent<CowboyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shootingPoint.position,transform.rotation);
        }
        if (!faceDir.faceLeft)
        {
            offset = -offset;
        }
        Vector2 screen_pos = Input.mousePosition;
        Vector2 world_pos = Camera.main.ScreenToWorldPoint(screen_pos);
        Aim(world_pos);
    }

    void Aim(Vector2 target)
    {
        Vector2 origin = (Vector2) transform.position + offset;
        Vector2 dir = target - origin;
        RaycastHit2D ray = Physics2D.Raycast(origin, dir);
        //RaycastHit2D[] hits = Physics2D.RaycastAll(origin, dir);
        //hits[0].collider.GetComponent<HealthBar>();
        //Debug.Log(string.Join(", ", hits));
        Vector2 end = ray.point;
        render.SetPosition(0, origin);
        render.SetPosition(1, end);

    }
}
