using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class PlayerReborn : MonoBehaviour
    {
        private string NowStage;
        // Start is called before the first frame update
        void Start()
        {
            NowStage = SceneManager.GetActiveScene().name;
        }

        // Update is called once per frame

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
            Debug.Log("reloaded");
                SceneManager.LoadScene(NowStage);
            }
        }
    }
