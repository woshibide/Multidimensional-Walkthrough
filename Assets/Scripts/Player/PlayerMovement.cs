
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public float axisMoveSpeed = 0f;

    // define region of movement
    [SerializeField] private Vector3 minBoundaries = new(0f, 0f, float.NegativeInfinity);
    [SerializeField] private Vector3 maxBoundaries = new(0f, 0f, float.PositiveInfinity);

    public SpawnManager spawnManager;

    void Boundaries()
    {
        //Restrict player from leaving region 
        transform.position = new Vector3(
        Math.Clamp(transform.position.x, minBoundaries.x, maxBoundaries.x),
        Math.Clamp(transform.position.y, minBoundaries.y, maxBoundaries.y),
        Math.Clamp(transform.position.z, minBoundaries.z, maxBoundaries.z));
    }

    void Movement()
    {
        Boundaries();

        // Get input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        var forwardInput = Input.mouseScrollDelta;

        float constantSpeed = (forwardInput.y * 10.0f) + 75f; // would be great to add or substract constant speed via scroll input

        // Debug.Log(constantSpeed);

        //convert input into movement
        transform.position += new Vector3(
            horizontalInput * axisMoveSpeed * Time.deltaTime / 10,
            verticalInput * axisMoveSpeed * Time.deltaTime / 10,
            constantSpeed * Time.deltaTime / 10); 
    }

    void Update()
    {
        Movement();
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}