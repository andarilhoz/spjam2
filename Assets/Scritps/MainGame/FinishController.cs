using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class FinishController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "spaceship")
        {
            if (Application.loadedLevelName == "MainGame")
                SceneManager.LoadScene("Lvl01");
            if (Application.loadedLevelName == "Lvl01")
                SceneManager.LoadScene("Lvl02");
            else
                SceneManager.LoadScene("Credits");
        }

    }
}

