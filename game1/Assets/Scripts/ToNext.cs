using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class ToNext : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(DataBase.GetNextStage());
    }
}
