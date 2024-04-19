using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(hInput, vInput, 0);

        transform.Translate (move * speed * Time.deltaTime);

    }
}
