using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateX = 0.1f;
    public float rotateY = 0.1f;
    public float rotateZ = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX,rotateY,rotateZ);    
    }
}
