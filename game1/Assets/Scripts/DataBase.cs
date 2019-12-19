using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataBase : MonoBehaviour
{
    public static string NowStage = "StageSelect";
    public static string NextStage = "StageSelect";
    public static float titleMusic = 0;
   
    public static string GetStage()
    {
    return NowStage;
     /*もう一度同じステージに行きたい場合は、stage = DataBase.getStage()でさっきやったステージ名を取得できる　ToPreStageをアタッチすればおｋ*/
    }
  
    public static void MusicContinue()
    {

    }
    
    public static string GetNextStage()
    {
        return NextStage;
    }
    
    public static void PutStage()
    {
        NowStage = SceneManager.GetActiveScene().name;
        NextStage = ToNext(NowStage);
    }
    
    public static string ToNext(string stage)
    {
        switch (stage)
        {
            case "Stage1":
                return "Stage2";
            case "Stage1(Hard)":
                return "Stage2(Hard)";
            case "Stage2":
                return "Stage3";
            case "Stage2(Hard)":
                return "Stage3(Hard)";
            case "Stage3":
                return "StageSelect";
            case "Stage3(Hard)":
                return "StageSelect(Hard)";
            default:
                return "StageSelect";
        }
        
    }
}
