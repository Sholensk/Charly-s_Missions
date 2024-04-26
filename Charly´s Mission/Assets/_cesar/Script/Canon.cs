using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public Bullet BulletPrefab;
    public Transform Shoot;
    public float RotationSpeed = 10;

    void Start()
    {



    }

    void Update()
    {

        Bullet bullet = Instantiate(BulletPrefab, Shoot.position, transform.rotation);
        bullet.LaunchBullet(transform.up);

    }
}
