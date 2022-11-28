using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{   
    public Camera cam1D;
    public Camera cam2D;
    public Camera cam3D;

    PlayerScript playerScript;
    //int yes = playerScript.scoreMultiplier;
    
    void Start()
    {
        // set first camera
        cam1D.gameObject.SetActive(true);
        cam2D.gameObject.SetActive(false);
        cam3D.gameObject.SetActive(false);
    }
    
    void Update()
    {
        // change camera on input
        if (cam1D.gameObject.activeSelf && Input.GetKeyDown("tab"))
        {
            cam1D.gameObject.SetActive(false);
            cam2D.gameObject.SetActive(true);
            cam3D.gameObject.SetActive(false);

            Debug.Log("1D -> 2D happened");
        }
        // change camera on input
        else if (cam2D.gameObject.activeSelf && Input.GetKeyDown("tab"))
        {
            cam1D.gameObject.SetActive(false);
            cam2D.gameObject.SetActive(false);
            cam3D.gameObject.SetActive(true);

            Debug.Log("2D -> 3D happened");
        }
        // change camera on input
        else if (cam3D.gameObject.activeSelf && Input.GetKeyDown("tab"))
        {
            cam1D.gameObject.SetActive(true);
            cam2D.gameObject.SetActive(false);
            cam3D.gameObject.SetActive(false);

            Debug.Log("3D -> 1D happened");
        }
    }
}
