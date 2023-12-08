using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using Unity.VisualScripting;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public GameObject cowboy;
    public LineRenderer render;
    public Vector2 offsetLeft;
    public int knockback;
    private Vector2 OffsetRight => new(-offsetLeft.x, offsetLeft.y);
    private Vector2 currentOffset;
    // public CowboyMovement faceDir;
    public KnightHealth knightHealth;
    public Collider2D knight;
    // public Transform bulletMover;
    public int bulletSpeed;
    public int bulletDamage;
    public bool FaceLeft { get; private set; } = true;


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
        Shooter(world_pos);

        if (world_pos.x < transform.position.x)
        {
            FaceLeft = true;
            transform.localScale = new(1, 1, 1);
        }
        else
        {
            FaceLeft = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (collision.transform.CompareTag("Knight") || collision.transform.CompareTag("Cowboy"))
        {
            knightHealth.KnightTakeDamage(bulletDamage);
        }
    }
    
    /// <summary>
    /// Aims with the white line at thingies and uses an if statement to instantiate a bullet
    /// at the end of a line.
    /// </summary>
    /// <param name="target"> Thingie to aim at</param>
    
    void Shooter(Vector2 target)
    {
        //Starting position
        Vector2 origin = (Vector2) transform.position + currentOffset;
        //Direction position
        Vector2 dir = target - origin;
        RaycastHit2D ray = Physics2D.Raycast(origin, dir);
        RaycastHit2D hits = Physics2D.RaycastAll(origin, dir).Where(x => x.collider.gameObject != gameObject).FirstOrDefault();
        Vector2 end = ray.point;
        render.SetPosition(0, origin);
        render.SetPosition(1, end);
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(bulletPrefab, origin, transform.rotation);
            // bulletMover = bullet.GetComponent<Transform>();
            Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
            rbBullet.velocity = dir.normalized * bulletSpeed;
            // bulletPrefab.transform.Translate(end);
            cowboy.GetComponent<Rigidbody2D>().AddForce(-knockback * dir.normalized);
        }
        currentOffset = FaceLeft ? offsetLeft : OffsetRight;
    }
}