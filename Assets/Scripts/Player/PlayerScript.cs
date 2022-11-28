using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour

{
    Rigidbody m_Rigidbody;

    // health
    public int playerHealth = 100;
    public bool playerDead = false;

    //ammo
    public int currentAmmo;
    public int maxAmmo = 15;
    public int minAmmo = 0;


    // score
    public int deadEnemies = 0;
    public int scoreMultiplier = 0;

    public void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.freezeRotation = true;

        //reload the gun at the start
        currentAmmo = maxAmmo;
    }
    
    public void TakeDamage(int damageAmount)
    {
        playerHealth -= damageAmount;
    }

    void Update()
    {
        if (playerHealth <= 0 && playerDead == false)
        {
            playerDead = true;
            SceneManager.LoadScene("NonGame");
            //Destroy(gameObject);
        }
    }
}

