using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class BombController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spaceship")
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (collision.gameObject.tag == "barrier")
        {
            Destroy(gameObject);
        }

    }
}
