using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPreStage : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(DataBase.GetStage());
    }
}
