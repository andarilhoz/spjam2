using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CheckLang : MonoBehaviour {
    public Image imagemFundo;
    public Sprite brSprite;
    public Sprite euSprite;
	// Use this for initialization
	void Start () {
        if (Messages.lingua == SystemLanguage.Portuguese)
            imagemFundo.sprite = brSprite;
        else
            imagemFundo.sprite = euSprite;


    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("Menu");

    }

}
