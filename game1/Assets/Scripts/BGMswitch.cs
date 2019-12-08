using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMswitch : MonoBehaviour
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
            this.targetText.text = "BGM   OFF";
            onOff = false;
        }
        else
        {
            this.targetText.text = "BGM   ON";
            onOff = true;
        }
    }
}
