using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void onButtonNewGame()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("MainGame");
        Debug.Log("Best SPJAM2");
    }
}
