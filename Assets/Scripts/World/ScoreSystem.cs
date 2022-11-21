using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    EnemyScript enemyScript;

    // Start is called before the first frame update
    void Awake()
    {
        enemyScript = GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("killed enemies: " + enemyScript.deadEnemies);
    }
}
