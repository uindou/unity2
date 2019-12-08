using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class GravityControll : MonoBehaviour
    {
        public float angle = 30;
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
            if (Mathf.Abs(transform.rotation.ToEuler().z) > Mathf.PI / 4 || Mathf.Abs(transform.rotation.ToEuler().x) > Mathf.PI / 4)
            {
                transform.rotation = defaultRot;
            }
            /*Physics physics = player.gameObject.GetComponent<Physics>();*/
            Vector3 GVec = transform.rotation.eulerAngles;
            GVec = GVec.normalized;
            Physics.gravity = new Vector3(0, -9.8f, 0) - GVec;
        }
    }
