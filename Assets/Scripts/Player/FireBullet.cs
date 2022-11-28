using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    PlayerScript playerScript;
    GameObject player;

    public GameObject spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 50f;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<PlayerScript>();
        Debug.Log(playerScript.currentAmmo);
    }

    public void Shoot()
    {
        spawnPoint = GameObject.FindWithTag("BulletSpawn");
        GameObject cB = Instantiate(bullet, spawnPoint.transform.position, bullet.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();
        rig.AddForce(spawnPoint.transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerScript.currentAmmo > 0)
            {
                Shoot();
                playerScript.currentAmmo--;
            }
            // should be attached to the same gameobject
            Debug.Log("ammo left " + playerScript.currentAmmo);
        }
    }
}
