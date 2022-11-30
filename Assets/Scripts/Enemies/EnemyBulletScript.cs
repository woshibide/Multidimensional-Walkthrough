using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // values of damage intake can be modified through power economy
            collision.gameObject.GetComponent<PlayerScript>().TakeDamage(2);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");

        // destroy bullet if it passed behind player
        if (gameObject.transform.position.z < player.transform.position.z - 3f)
        {
            Destroy(gameObject);
        }
    }
}
