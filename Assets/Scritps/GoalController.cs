using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class GoalController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "spaceship")
        //{
        //    transform.position = new Vector3(-12, 0, 0);
        //}

    }
}
