using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public float angle = 30;
    public float xAngleLimit;
    public float zAngleLimit;
    //private float MaxAngle = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Quaternion defaultRot = transform.rotation;
        transform.rotation *= Quaternion.AngleAxis(ArrowButtom.lr * Time.deltaTime * angle, new Vector3(0, 0, 1));
        transform.rotation *= Quaternion.AngleAxis(ArrowButtom.pd * Time.deltaTime * angle, new Vector3(1, 0, 0));
        if (Mathf.Abs(transform.rotation.ToEuler().z) > zAngleLimit * Mathf.PI / 180 || Mathf.Abs(transform.rotation.ToEuler().x) > xAngleLimit * Mathf.PI / 180)
        {
            transform.rotation = defaultRot;
        }
    }


}
