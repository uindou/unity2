using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : MonoBehaviour
{
    static public float lr;
    static public float pd;
    static private bool push;
    static private int vec = 0;//0 ue 1 sita 2 migi 3 hidari
    private float dx = 1f;

    // Start is called before the first frame update
    void Start()
    {
        push = false;
        lr = 0;
        pd = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (push)
        {
            int hugou = vec % 2 == 0 ? 1 : -1;
            if (vec >= 2)
            {
                lr = hugou * dx;
            }
            else
            {
                pd = hugou * dx;
            }
        }
        else
        {
            lr = 0;
            pd = 0;
        }
    }

    public void PushDowm()
    {
        string name = this.gameObject.name;
        if (name == "UpArrow")
        {
            vec = 0;
        }else if (name == "DownArrow")
        {
            vec = 1;
        }else if(name == "LeftArrow")
        {
            vec = 2;
        }else if(name == "RightArrow")
        {
            vec = 3;
        }
        push = true;
     }
    public void PushUp()
    {
        push = false;
        Debug.Log("離した");
    }
}
