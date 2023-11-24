using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using Unity.VisualScripting;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public GameObject cowboy;
    public LineRenderer render;
    public Vector2 offset;
    public CowboyMovement faceDir;
    public KnightHealth knightHealth;
    public Collider2D knight;


    // Start is called before the first frame update
    void Start()
    {
        _ = Input.mousePosition;
        _ = cowboy.GetComponent<CowboyMovement>();
    }
    
    void Update()
    {

        Vector2 screen_pos = Input.mousePosition;
        Vector2 world_pos = Camera.main.ScreenToWorldPoint(screen_pos);
        Aim(world_pos);
        
        /// Creates a bullet when pressing Space button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, world_pos, transform.rotation);  
        }
        if (!faceDir.faceLeft)
        {
            offset = -offset;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Hits Target");
        if (collision.transform.CompareTag("Knight"))
        {
            knightHealth.KnightTakeDamage(20);
        }
    }
    
    /// <summary>
    /// Aims with the white line at thingies
    /// </summary>
    /// <param name="target"> Thingie to aim at</param>
    void Aim(Vector2 target)
    {
        Vector2 origin = (Vector2) transform.position + offset;
        Vector2 dir = target - origin;
        RaycastHit2D ray = Physics2D.Raycast(origin, dir);
        RaycastHit2D hits = Physics2D.RaycastAll(origin, dir).Where(x => x.collider.gameObject != gameObject).FirstOrDefault();
        //hits[0].collider.GetComponent<HealthBar>();
        //Debug.Log(string.Join(", ", hits));
        Vector2 end = ray.point;
        render.SetPosition(0, origin);
        render.SetPosition(1, end);
    }
}