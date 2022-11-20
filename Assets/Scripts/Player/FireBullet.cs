using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    PlayerScript playerScript;

    public Transform spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 50f;

    public void ShootBullet()
    {
        if (playerScript.currentAmmo > playerScript.minAmmo)
        {
            Debug.Log("if entered");
            GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
            Debug.Log("18th line read");
            Rigidbody rig = cB.GetComponent<Rigidbody>();
            Debug.Log("21st line read");

            rig.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
            Debug.Log("24th line read");

            playerScript.currentAmmo--;
            Debug.Log("26th line read");

            Debug.Log("bullet was shot");
        }
        else
        {
            Debug.Log("No ammo to fire");
        }
    }
}
