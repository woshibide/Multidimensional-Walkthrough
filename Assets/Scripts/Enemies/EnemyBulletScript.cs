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

        else
        {
            Destroy(gameObject, 1.0f);
            //Debug.Log("bullet destroyed");
        }
    }
}
