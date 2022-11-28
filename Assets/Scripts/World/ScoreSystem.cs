using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    EnemyScript enemyScript;
    PlayerScript playerScript;

    // int currentScore = 0;
    // int scoreMultiplier = 10; // will be changed according to dimension 

    void Awake()
    {
        enemyScript = GetComponent<EnemyScript>();
        //int currentScore = 0;
    }

    private void Start()
    {
        // int currentScore = 0;
        // int scoreMultiplier = 10; // will be changed according to dimension 
    }

    void Update()
    {
        // int currentScore = playerScript.deadEnemies * playerScript.scoreMultiplier;

        //Debug.Log("score: " + currentScore);
        //Debug.Log("killed enemies: " + enemyScript.deadEnemies);
        //Debug.Log("score: " + (enemyScript.deadEnemies * scoreMultiplier));
    }
}
