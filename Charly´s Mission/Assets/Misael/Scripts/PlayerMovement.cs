using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalmove = 0;
    float verticalmove = 0;
    public float runspeedhorizontal = 3;
    public float runspeedvertical = 3;
    public float runspeed = 0;
    Rigidbody2D Rigidbody2D;
    public Joystick joystick;
    public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
<<<<<<< HEAD
        if (joystick.Vertical >= 0.3f && Isgrounded.isgrounded)
=======
        if (joystick.Vertical >= 0.2f && Isgrounded.isgrounded)
>>>>>>> 1ab323d8437350f85b5f0be219e4eb34c4c78b61
        {
            Jump();
        }
        
        horizontalmove = joystick.Horizontal * runspeedhorizontal;

        transform.position += new Vector3(horizontalmove, 0, 0) * Time.deltaTime * runspeed;
    }
    public void Jump()
    {
     gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
    }
}
