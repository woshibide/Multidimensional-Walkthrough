using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // [SerializeField] private regionBoundaries = Vector3();
    [SerializeField] private float regionOffset = 50f;

    [SerializeField] private GameObject enemyToSpawn;

    void Start()
    {
        Transform.Instantiate(enemyToSpawn, new Vector3(0, 0, 100), Quaternion.identity);
   
    }


    public void AwakeTheEvil()
        {
        float newZ = transform.position.z + regionOffset;
        Vector3 newRegion = transform.position = new Vector3(0, 0, newZ);

        Transform.Instantiate(enemyToSpawn, newRegion, Quaternion.identity);
    }
}