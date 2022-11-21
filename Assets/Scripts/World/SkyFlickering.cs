using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkyFlickering : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.Rotate((player.transform.localPosition.z * Time.deltaTime), 0f, 0f);
    }
}

