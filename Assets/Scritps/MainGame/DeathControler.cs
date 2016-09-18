using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


public class DeathControler : MonoBehaviour
{
    public bool isDestroied = false;


    public Color colorStart;
    public Color colorEnd;
    public float duration = 5.0f;



    public ParticleSystem explosion;
    private ParticleSystem.EmissionModule explosionEmit;

    private PlayerController player;

    void Start()
    {
        explosionEmit = explosion.emission;
        player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.isDead)
        {
            if (!isDestroied)
            {
                explosion.Play();

                player.render.sprite = player.destroiedSpaceShip;
                isDestroied = true;
            }



            if (!explosion.isPlaying)
            {
                fadeOut();
            }

        }
    }


    void fadeOut()
    {
        int fadeSpeed = 1;
        Color colorEnd;

        float alpha = player.render.material.color.a - Time.deltaTime / (fadeSpeed == 0 ? 1 : fadeSpeed);

        colorEnd = new Color(player.render.material.color.r, player.render.material.color.g, player.render.material.color.b, alpha);
        player.render.material.SetColor("_Color", colorEnd);


        if (alpha <= 0)
        {
            resetPlayer();
        }

    }

    void resetPlayer()
    {
        player.isDead = false;
        isDestroied = false;
        transform.position = player.posInitial;
        player.render.sprite = player.spaceShip;
        player.render.material.SetColor("_Color", new Color(player.render.material.color.r, player.render.material.color.g, player.render.material.color.b, 1f));
    }


}

