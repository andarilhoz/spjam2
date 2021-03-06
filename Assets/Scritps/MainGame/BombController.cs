﻿using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class BombController : MonoBehaviour
{

    public ParticleSystem explosion;
    public SpriteRenderer render;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "spaceship" || collision.gameObject.tag == "barrier" )
        {
            Explode(transform.position);
            //render.material.SetColor("_Color", new Color(render.material.color.r, render.material.color.g, render.material.color.b, 0f));
            //yield return new WaitForSeconds(1f);
            //explosion.Play();
            Destroy(gameObject);            
        }        

    }
    public void Explode(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
    }
}
