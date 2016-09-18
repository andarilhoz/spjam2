using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class BarrierController : MonoBehaviour
{
    public ParticleSystem particulas;
    private ParticleSystem.EmissionModule particulasem;

    void Start() {
        particulasem = particulas.emission;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bomb")
        {
            particulas.Simulate(0.0f, true, true);
            particulasem.enabled = true;
            particulas.Play();
            Destroy(gameObject);
        }

    }
}
