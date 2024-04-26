using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public float destroyDelay = 2f;
    private GameObject _bulletRb;
    public Rigidbody2D Rb;

    void Awake()
    {

        Rb = _bulletRb.GetComponent<Rigidbody2D>();

    }

    public void LaunchBullet(Vector2 direction)
    {
        Rb.velocity = direction * speed;
        Destroy(gameObject, destroyDelay);
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

}
