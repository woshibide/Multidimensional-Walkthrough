using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public float axisMoveSpeed = 3.5f;

    // define region of movement
    [SerializeField] private Vector3 minBoundaries = new(-2.5f, 0.3f, -5f);
    [SerializeField] private Vector3 maxBoundaries = new(2.5f, 10f, float.PositiveInfinity);

    public SpawnManager spawnManager;

    void Update()
    {  
        Movement();
        
        void Movement()
        {
            Boundaries();

            // Get input
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            var forwardInput = Input.mouseScrollDelta;

            //convert input into movement
            transform.position += new Vector3(
                horizontalInput * axisMoveSpeed * Time.deltaTime / 10,
                verticalInput * axisMoveSpeed * Time.deltaTime / 10,
                forwardInput.y / 10);
        }
    }
        
        void Boundaries()
        {
        //Restrict player from leaving region 
        transform.position = new Vector3(
            Math.Clamp(transform.position.x, minBoundaries.x, maxBoundaries.x),
            Math.Clamp(transform.position.y, minBoundaries.y, maxBoundaries.y),
            Math.Clamp(transform.position.z, minBoundaries.z, maxBoundaries.z));
        }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}