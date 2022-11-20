using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            // values of damage intake can be modified through power economy
            collision.gameObject.GetComponent<EnemyScript>().TakeDamage(5);

            Destroy(gameObject);
        }

        else
        {
            // ????????????????????????
            // doesnt work
            // ????????????????????????

            Destroy(gameObject, 2f);
        }
    }
}