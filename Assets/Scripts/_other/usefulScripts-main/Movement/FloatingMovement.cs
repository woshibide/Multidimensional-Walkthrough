using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{

    // timeshift sounds fancy, but it basically just makes it possible to animate
    // the floating movement out of sync, so it looks more natural with multiple objects
    public Vector3 timeShift = new Vector3(0,0,0);

    // how fast should the object move on which axis?
    public Vector3 speed = new Vector3(1,1,1);

    // how far should the movement go?
    public Vector3 range = new Vector3(0.1f, 0.1f, 0.1f);

    // save the old position
    private Vector3 oldPosition;

    // Start is called before the first frame update
    void Start()
    {
        oldPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        float x = Mathf.Sin((time * speed.x) + timeShift.x) * range.x;
        float y = Mathf.Cos((time * speed.y) + timeShift.y) * range.y;
        float z = Mathf.Sin((time * speed.z) + timeShift.z) * range.z;
        transform.localPosition = oldPosition + new Vector3(x,y,z); 
    }
}
