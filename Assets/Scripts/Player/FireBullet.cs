using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    PlayerScript playerScript;

    public Transform spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 50f;

    public void Shoot()
    {
        GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();
        rig.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);

        Debug.Log("player fired");
        Debug.Log("ammo left " + playerScript.currentAmmo); // why this doesnt show up???????????????
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
