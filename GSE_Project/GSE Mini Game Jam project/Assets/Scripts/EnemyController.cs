using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    Green = 0,
    Yellow = 1,
    Red = 2

}
public class EnemyController : MonoBehaviour
{
    public List<GameObject> SpawnPoints;
    public Enemy EnemyPrefab;
    public float InitialSpawnDelay;
    public float SpawnDelayInterval;
    public List<Enemy> ActiveEnemies;

    public Vector2 MovementDelay;
    public float GreenPatientSpeed;
    public float YellowPatientSpeed;
    public float RedPatientSpeed;

    // Start is called before the first frame update
    void Start()
    {
        InitializeEnemies();
    }

    void InitializeEnemies()
    {
        // StartCoroutine(StartSpawningEnemies());
        InvokeRepeating("StartSpawningEnemies", InitialSpawnDelay, SpawnDelayInterval);
    }

    int mLastUsedSpawnPoint = 0;
    void StartSpawningEnemies()
    {
        int spawnPointID = Random.Range(0, SpawnPoints.Count);
        if (mLastUsedSpawnPoint == spawnPointID)
        {
            spawnPointID = Random.Range(0, SpawnPoints.Count);
        }
        
        var enemy = Instantiate(EnemyPrefab, SpawnPoints[spawnPointID].transform);
        ActiveEnemies.Add(enemy);
        enemy.MovementDelay = Random.Range(MovementDelay.x, MovementDelay.y);
 
        int SpawnPatient = Random.Range(0, 3);
        
        if (SpawnPatient == 0)
            enemy.Initialize(EnemyType.Green, -GreenPatientSpeed);
        else if (SpawnPatient == 1)
            enemy.Initialize(EnemyType.Yellow, -YellowPatientSpeed);
        else if (SpawnPatient == 2)
            enemy.Initialize(EnemyType.Red, -RedPatientSpeed);
        
    }

}
