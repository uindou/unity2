using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemyQuantity;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    private List<GameObject> enemyList = new List<GameObject>();

    public static T GetRandom<T>(List<T> list)
    {
        T target = list[UnityEngine.Random.Range(0, list.Count)];
        list.Remove(target);
        return target;
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(enemy1);
        enemyList.Add(enemy2);
        enemyList.Add(enemy3);
        enemyList.Add(enemy4);
        
        for (int i=0; i < enemyQuantity; i++)
        {
            GetRandom(enemyList).SetActive(true);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
