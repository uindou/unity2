using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpWindow : MonoBehaviour
{
    public bool check = false;//条件分岐用のbool変数
    public GameObject panel;

    public void OnClick()
    {
        if (!check)
        {
            panel.SetActive(false);
        }
        else
        if (check)
        {
            panel.SetActive(true);
            Debug.Log("パネルを表示するよ");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
