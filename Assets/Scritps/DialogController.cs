using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogController : MonoBehaviour {
    public Text dialogText;
    public float delayDialog;

    private List<string> allDialogs = new List<string>();
    private int actualDialog = 0;
    private string text;
    private bool canChange;
    private float lastChange;
    public bool waitingForPlayer;
    public bool waitingAnimation;

    // Use this for initialization
    void Start() {
        Debug.Log("teste");
        // dialogText = dialogText.GetComponent<Text>();

        waitingForPlayer = false;
        waitingAnimation = true;

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
        allDialogs.Add("CARA19");

        changeDialog();
    }

    // Update is called once per frame
    void Update() {
        if (waitingAnimation || waitingForPlayer)
        {
            GameObject.Find("DialogManager").SetActive(false);
        }
        else {
            GameObject.Find("DialogManager").SetActive(true);
        }
        
        if (text != "" && canChange)
        {
            lastChange = Time.realtimeSinceStartup;
            canChange = false;
            text = dialogText.text;
            dialogText.text = Messages.stringList[text];
        }

        if (Time.realtimeSinceStartup - lastChange > delayDialog) {
            Debug.Log(allDialogs.Count);
            if (!waitingAnimation && (actualDialog < allDialogs.Count && !waitingForPlayer))
            {
                changeDialog();
            }
        }
            
    }

    void changeDialog() {
        dialogText.text = allDialogs[actualDialog];
        actualDialog ++;
        canChange = true;
    }


}
