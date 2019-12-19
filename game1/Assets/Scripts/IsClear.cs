using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class IsClear : MonoBehaviour
{
    private int winCount = 0;
    public int enemyQuantity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            winCount += 1;
            other.gameObject.SetActive(false);
            Debug.Log(winCount);
            if(winCount == enemyQuantity)
            {
                Debug.Log(other.name);
                DataBase.PutStage();
                SceneManager.LoadScene("Clear");
            }
        }
    }
}
