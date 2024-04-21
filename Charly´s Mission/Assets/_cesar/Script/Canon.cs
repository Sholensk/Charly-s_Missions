using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public Bullet BulletPrefab;
    public Transform Shoot;
    public float RotationSpeed = 10;
    private Camera _maincam; //La camara se usara como punto de referencia para el world space

    void Start()
    {

        _maincam = Camera.main;

    }

    void Update()
    {
        Vector2 Mouse = _maincam.ScreenToWorldPoint(Input.mousePosition); //Convertir la posicion del mouse en el espacio del mundo
        Vector2 direction = Mouse - (Vector2)transform.position;
        transform.up = Vector2.MoveTowards(transform.up, direction, RotationSpeed * Time.deltaTime); //Suaviza el movimieto del cañon

        if(Input.GetMouseButtonDown(0))
        {
            Bullet bullet = Instantiate(BulletPrefab, Shoot.position, transform.rotation);
            bullet.LaunchBullet(transform.up);
        }

    }
}
