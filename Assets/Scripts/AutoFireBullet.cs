using UnityEngine;
using Random = System.Random;

public class AutoFireBullet : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 50f;
    Random rand = new();

    void AutoShootBullet()
    {
        GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();

        rig.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        int chance = rand.Next(0, 100);

        if (chance == 1)
            AutoShootBullet();
    }

}
