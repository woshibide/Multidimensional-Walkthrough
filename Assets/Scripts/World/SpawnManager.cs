using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    FloorSpawner floorSpawner;
    EnemySpawner enemySpawner;
    ObstacleSpawner obstacleSpawner;

    void Start()
    {
        floorSpawner = GetComponent<FloorSpawner>();
        enemySpawner = GetComponent<EnemySpawner>();
        obstacleSpawner = GetComponent<ObstacleSpawner>();
    }

    public void SpawnTriggerEntered()
    {
        floorSpawner.MoveFloor();
        enemySpawner.AwakeTheEvil();
        obstacleSpawner.SpawnObstacles();
    }

}