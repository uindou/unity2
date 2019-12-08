using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSswitch : MonoBehaviour
{
    public Text targetText;
    private bool onOff = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (onOff == true)
        {
            this.targetText.text = "Sound Effect OFF";
            onOff = false;
        }
        else
        {
            this.targetText.text = "Sound Effect ON";
            onOff = true;
        }
    }
}
