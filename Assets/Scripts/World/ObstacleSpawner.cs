using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float spawnOffset = 20.0f;

    public GameObject obstacleToSpawn;
    public int obstaclesNum = 7;

    void Start()
    {
        Transform.Instantiate(obstacleToSpawn, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void SpawnObstacles()
    {
        float newZ = transform.position.z + spawnOffset;
        Vector3 newRegion = transform.position = new Vector3(0, 0, newZ);

        Transform.Instantiate(obstacleToSpawn, newRegion, Quaternion.identity);
    }
}