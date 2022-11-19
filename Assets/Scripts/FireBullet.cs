using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    PlayerScript playerScript;

    public Transform spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 5f;

    void ShootBullet()
    {
        if (playerScript.currentAmmo > playerScript.minAmmo)
        {
            GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
            Rigidbody rig = cB.GetComponent<Rigidbody>();

            rig.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);

            playerScript.currentAmmo --;

            Debug.Log("bullet was shot");
        }

        else
        {
            Debug.Log("No ammo to fire");
        }

    }

}
