using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isgrounded : MonoBehaviour
{
    public static bool isgrounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isgrounded = true;

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isgrounded = false;

    }

}
