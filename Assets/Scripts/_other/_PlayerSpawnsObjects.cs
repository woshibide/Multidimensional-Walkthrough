using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerSpawnsObjects : MonoBehaviour
{
    // what and where to spawn
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Vector3 minPosition;
    [SerializeField] private Vector3 maxPosition;
    [SerializeField] public static int numberOfEnemies = 5;

    // mechanism of iniating a spawn
    public GameObject spawnWall;
    public GameObject spawnWallTrigger;
    public float spawnDistance = 10f;
    public float spawnWallDistance = 10f;
    private float nextSpawnWall = 15f;

    //public SpawnManager spawnManager;
    
    void Start()
    {
        {
            //int j = 0;
            //while (j < numberOfEnemies) 
            //{
            //    Vector3 randomPosition = new (
            //        Random.Range(minPosition.x, maxPosition.x),
            //        Random.Range(minPosition.y, maxPosition.y),
            //        Random.Range(minPosition.z, maxPosition.z)
            //    );

            //    Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            //    j++;

            //    Debug.Log(objectToSpawn.name + " spawned");
            //}
        }

        nextSpawnWall = transform.position.z;
        spawnWall.transform.position = new Vector3(0f, 0f, nextSpawnWall);

        Debug.Log(spawnWall.transform.position = new Vector3(0f, 0f, nextSpawnWall));
    }

    void Update()
    {
        if (spawnWallTrigger.transform.position.z < nextSpawnWall)
        {
            float currentSpawnWall = nextSpawnWall;

            for (int j = 0; j < numberOfEnemies; j++)
            {
                // spawn enemies within defined region
                Vector3 randomPosition = new Vector3(
                    Random.Range(minPosition.x, maxPosition.x),
                    Random.Range(minPosition.y, maxPosition.y),
                    Random.Range(minPosition.z, maxPosition.z)
                ) + new Vector3(0f, 0f, spawnDistance);

                // wtf is this
                randomPosition += new Vector3(0f, 0f, currentSpawnWall);
                
                Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

            }
            nextSpawnWall += spawnWallDistance;
            spawnWall.transform.position = new Vector3(0f, 0f, nextSpawnWall);
            Debug.Log("broke spawnWall " + nextSpawnWall);
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    spawnManager.SpawnTriggerEntered();
    //}

}
