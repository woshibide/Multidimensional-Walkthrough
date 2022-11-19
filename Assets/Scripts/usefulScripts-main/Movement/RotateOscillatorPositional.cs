using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOscillatorPositional : MonoBehaviour
{
    // offset makes it possible to animate the rotation out of sync
    // so it looks more natural with multiple objects
    // or you can offset an axis
    public Vector3 offset = new Vector3(0,0,0);

    // how much should the position influence the offset
    public float positionalStrength = 1.0f;

    // how fast should the object move on which axis?
    public Vector3 speed = new Vector3(1,1,1);

    // how far should the movement go?
    public Vector3 rangeDegrees = new Vector3(90,90,90);

    // to save the old rotation, so it starts rotating from there
    private Vector3 oldRotation;

    // Start is called before the first frame update
    void Start()
    {
        // here we save the old oldRotation
        // eulerangles is giving you a "normal" rotation in three axisses (what is the plural of axis? no idea)
        // you want that
        oldRotation = transform.localRotation.eulerAngles;
        offset += transform.position * positionalStrength;
    }

    // Update is called once per frame
    void Update()
    {
        // to animate the rotation, we need to know the time
        // this is the number of seconds since the project started
        float time = Time.time;

        // Mathf.Sin generates a smooth oscillation between -1 and 1
        // if you multiply time by speed, then it goes faster,
        // and if you add offset to it, you "shift" the movement in time
        // if you multiply the result by the range, you can increase or decrease the maxima
        // so if you multiply by 20 it "swings" between -20 and 20
        float x = Mathf.Sin((time * speed.x) + offset.x) * rangeDegrees.x;
        float y = Mathf.Sin((time * speed.y) + offset.y) * rangeDegrees.y;
        float z = Mathf.Sin((time * speed.z) + offset.z) * rangeDegrees.z;
        
        // apply it! Quaternion is just something you have to use.
        // there is a fascinating technical explanation for it, but you can ignore that for now
        transform.localRotation = Quaternion.Euler(oldRotation.x + x, oldRotation.y + y,oldRotation.z + z);    
    }
}

