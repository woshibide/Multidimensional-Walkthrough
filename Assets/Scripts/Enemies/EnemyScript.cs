using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public int deadEnemies = 0;

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
            enemyDead = true;
            Destroy(gameObject);

            deadEnemies++;
        }
    }
}

