using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public float destroyDelay = 2f;
    private Rigidbody2D _bulletRb;

    void Awake()
    {

        _bulletRb = GetComponent<Rigidbody2D>();

    }

    public void LaunchBullet(Vector2 direction)
    {
        _bulletRb.velocity = direction * speed;
        Destroy(gameObject, destroyDelay);
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

}
