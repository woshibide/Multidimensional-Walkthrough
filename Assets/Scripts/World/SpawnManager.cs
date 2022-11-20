using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    FloorSpawner floorSpawner;
    EnemySpawner enemySpawner;

    void Start()
    {
        floorSpawner = GetComponent<FloorSpawner>();
        enemySpawner = GetComponent<EnemySpawner>();
    }

    public void SpawnTriggerEntered()
    {
        floorSpawner.MoveFloor();
        enemySpawner.AwakeTheEvil();
    }

}