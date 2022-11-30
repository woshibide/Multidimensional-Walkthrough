using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnOffset = 10f;

    public GameObject enemyToSpawn;
    public int numberOfEnemies = 5;

    void Start()
    {
        Transform.Instantiate(enemyToSpawn, new Vector3(0, 2.5f, 0), Quaternion.identity);
    }

    public void AwakeTheEvil()
    {
        float newZ = transform.position.z + spawnOffset;
        Vector3 newRegion = transform.position = new Vector3(0, 2.5f, newZ);

        Transform.Instantiate(enemyToSpawn, newRegion, Quaternion.identity);
    }
}