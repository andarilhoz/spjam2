using UnityEngine;
using System.Collections;

public class SetLanguage : MonoBehaviour
{

    void Awake()
    {
        //first we'll set "en" (english) as the default language
        Messages.SetLanguage(Application.systemLanguage);

        //if the system language isn't included in here, then the game will show the texts only in the default language

        Debug.Log("Language set: " + Application.systemLanguage);
    }

}