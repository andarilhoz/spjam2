using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogController : MonoBehaviour {
    public Text dialogText;
    public float delayDialog;
    public Image dialogBackground;

    private List<string> allDialogs = new List<string>();
    private int actualDialog = 0;
    private string text;
    private bool canChange;
    public static float lastChange;
    public bool waitingForPlayer;
    public bool waitingAnimation;
    public static bool tutorial;
    public static bool tutorialEnd = false;
    private int didTutorialTimes = 0;
    public Image perfil;
    public Sprite General;
    public Sprite Robot;

    void Awake() {
        if(didTutorialTimes > 0)
            tutorialEnd = true;
    }

    // Use this for initialization
    void Start() {
        // dialogText = dialogText.GetComponent<Text>();
        waitingForPlayer = false;
        waitingAnimation = true;
        tutorialEnd = true;//tutorialEnd = false;
        perfil.sprite = General;
        perfil.enabled = false;
        dialogText.enabled = false;
        dialogBackground.enabled = false;

        allDialogs.Add("hooverCap00");
        allDialogs.Add("hooverCap01");
        allDialogs.Add("hooverCap02");
        allDialogs.Add("hooverCap03");

        allDialogs.Add("CARA01");
        allDialogs.Add("CARA02");
        allDialogs.Add("CARA03");
        allDialogs.Add("CARA04");
        allDialogs.Add("CARA05");
        allDialogs.Add("CARA06");
        allDialogs.Add("CARA07");
        allDialogs.Add("CARA08");

        allDialogs.Add("CARA09");
        allDialogs.Add("CARA10");
        allDialogs.Add("CARA11");
        allDialogs.Add("CARA12");
        allDialogs.Add("CARA13");
        allDialogs.Add("CARA14");
        allDialogs.Add("CARA15");
        allDialogs.Add("CARA16");
        allDialogs.Add("CARA17");
        allDialogs.Add("CARA18");

        changeDialog();
        tutorial = false;
        GameObject.Find("DialogManager").SetActive(false);
        

    }

    // Update is called once per frame
    void Update() {

        waitingAnimation = PlayerController.animation;
        waitingForPlayer = PlayerController.fazendoTutorial;

        if (waitingAnimation)
        {
            GameObject.Find("DialogPhoto").SetActive(false);
            GameObject.Find("DialogBackground").SetActive(false);
            GameObject.Find("DialogText").SetActive(false);
        }
        else {
            GameObject.Find("DialogPhoto").SetActive(true);
            GameObject.Find("DialogBackground").SetActive(true);
            GameObject.Find("DialogText").SetActive(true);

        }
        
        if (text != "" && canChange)
        {
            if (!waitingForPlayer)
            {
                tutorial = true;
            }
            lastChange = Time.realtimeSinceStartup;
            canChange = false;
            text = dialogText.text;
            dialogText.text = Messages.stringList[text];
            if (actualDialog > 4)
            {
                perfil.sprite = Robot;
            }
        }
        
        if (Time.realtimeSinceStartup - lastChange > delayDialog) {
            if (!waitingAnimation && (actualDialog < allDialogs.Count && !waitingForPlayer))
            {
                changeDialog();
            }
            else if (actualDialog >= allDialogs.Count) {
                tutorial = false;
                tutorialEnd = true;
                didTutorialTimes++;
                PlayerController.fazendoTutorial = true;
                GameObject.Find("DialogPhoto").SetActive(false);
                GameObject.Find("DialogBackground").SetActive(false);
                GameObject.Find("DialogText").SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (actualDialog < allDialogs.Count)
            {
                changeDialog();
            }
        }

    }

    void changeDialog() {
        dialogText.text = allDialogs[actualDialog];
        switch (actualDialog) {
            case 0:case 8: case 9: case 13: case 17:
                tutorial = false;
                PlayerController.fazendoTutorial = true;
                break;
            default:
                
                break;
        }
        canChange = true;
        actualDialog ++;

    }



}
