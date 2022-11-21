using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class EnemyScript : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;

    Rigidbody m_Rigidbody;

    public void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.freezeRotation = true;
    }


    public void TakeDamage(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            GameObject player = GameObject.FindWithTag("Player");
            var playerScript = player.GetComponent<PlayerScript>();
            playerScript.TakeDamage(-5);
            playerScript.deadEnemies++;
            enemyDead = true;
            Destroy(gameObject);
        }
    }
}

