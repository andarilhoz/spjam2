using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void onButtonNewGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void onButtonExit() {
        Application.Quit();
    }

    public void onButtonCredits() {
        SceneManager.LoadScene("Credits");
    }

    public void onButtonGo() {
        SceneManager.LoadScene("MainGame"); 
    }

}
