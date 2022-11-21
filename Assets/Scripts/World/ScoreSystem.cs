using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    EnemyScript enemyScript;
    private int scoreMultiplier;


    void Awake()
    {
        enemyScript = GetComponent<EnemyScript>();
    }

    private void Start()
    {
        int currentScore = 0;
        int scoreMultiplier = 10; // will be changed according to dimension 
    }

    void Update()
    {
        Debug.Log("im working");
        //Debug.Log("killed enemies: " + enemyScript.deadEnemies);
        //Debug.Log("score: " + (enemyScript.deadEnemies * scoreMultiplier));
    }
}
