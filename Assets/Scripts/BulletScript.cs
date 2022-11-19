using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // EnemyScript enemyScript;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            // values of damage intake can be modified through power economy
            collision.gameObject.GetComponent<EnemyScript>().TakeDamage(5);

            Destroy(gameObject);
        }
    }

    void Update()
    {
       
    }
}


//private void OnCollisionEnter(Collision collision)
//{
//if (collision.transform.tag == "Enemy")
//{
//    // do damage here, for example:
//    collision.gameObject.GetComponent<Enemy>().TakeDamage(5);