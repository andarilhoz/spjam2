using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SetLanguage : MonoBehaviour
{


    public void setBr() {
        Messages.SetLanguage(SystemLanguage.Portuguese);
        SceneManager.LoadScene("Menu");
    }

    public void setING()
    {
        Messages.SetLanguage(SystemLanguage.English);
        SceneManager.LoadScene("Menu");
    }

}