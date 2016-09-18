using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]

public class FinishController : MonoBehaviour
{

    public ParticleSystem explosion;

    public SpriteRenderer render;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "spaceship")
        {
            if (Application.loadedLevelName == "MainGame")
                SceneManager.LoadScene("Lvl01");
            else
                SceneManager.LoadScene("Credits");
        }

    }
}

