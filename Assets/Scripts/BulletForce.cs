using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletForce : MonoBehaviour
{
    public GameObject bulletPrefab;
    Rigidbody2D rb;
    public float bulletSpeed;
    Bullet bullets;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullets = GameObject.Find("Player").GetComponent<Bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.up * bulletSpeed);
        rb.velocity = transform.up * bulletSpeed;
        //if (transform.position.y > 4f)
            //bullets.BackToPool(gameObject);   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement player;
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            bullets.BackToPool(gameObject);
            player = GameObject.Find("Player").GetComponent<PlayerMovement>();
            player.ScoreCalculator(10);
         
            //Destroy(bulletPrefab);

        }
    }
}
