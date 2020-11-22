using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyTypes
{
    Green = 0,
    Yellow = 1,
    Red = 2

}
public class EnemyController : MonoBehaviour
{
    public List<GameObject> SpawnPoints;
    public Enemy EnemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void InitializeEnemies()
    {
        StartCoroutine(StartSpawningEnemies());
    }

    IEnumerator StartSpawningEnemies()
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
