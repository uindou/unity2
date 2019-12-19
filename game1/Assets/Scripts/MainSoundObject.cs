using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSoundObject : MonoBehaviour
{

    public bool DontDestroyEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if(DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Stage1" || SceneManager.GetActiveScene().name == "Stage2" || SceneManager.GetActiveScene().name == "Stage3")
        { 
            Destroy(this.gameObject);
        }
        */
    }
}
