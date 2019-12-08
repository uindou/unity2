using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy")
        {
            Debug.Log(other.name);
            DataBase.PutStage();
            SceneManager.LoadScene("Clear");
        }
    }
}
