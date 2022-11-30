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
        GameObject player = GameObject.FindWithTag("Player");

        if (enemyHealth <= 0 && enemyDead == false)
        {
            var playerScript = player.GetComponent<PlayerScript>();

            playerScript.TakeDamage(-5);
            playerScript.deadEnemies++;

            enemyDead = true;
            Destroy(gameObject);
        }
        // destroy enemy if player passed it by 
        if (gameObject.transform.position.z < player.transform.position.z - 3f)
        {
            Destroy(gameObject);
        }
    }
}

