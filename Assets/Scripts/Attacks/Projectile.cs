using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody2D rigidbodyFireball;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyFireball = GetComponent<Rigidbody2D>();
        rigidbodyFireball.velocity = transform.right * projectileSpeed;

    }

    private void FixedUpdate()
    {
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "WoodBox")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
