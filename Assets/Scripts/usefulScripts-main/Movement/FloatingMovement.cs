using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    public Vector3 timeShift = new Vector3(0,0,0);
    public Vector3 speed = new Vector3(1,1,1);
    public Vector3 range = new Vector3(1,1,1);
    private Vector3 oldPosition;

    void Start()
    {
        oldPosition = transform.localPosition;
    }

    void RandEachInstance()
    {
        //for (int j = 0; j < PlayerSpawnsObjects.numberOfEnemies; j++)

        //    float x = Mathf.Sin((time * speed.x) + timeShift.x) * range.x;
        //    float y = Mathf.Cos((time * speed.y) + timeShift.y) * range.y;
        //    float z = Mathf.Sin((time * speed.z) + timeShift.z) * range.z;

        //int j = 0;
        //while (j < PlayerSpawnsObjects.numberOfEnemies)
        {
            //float time = Time.time;

            //float x = Mathf.Sin((time * speed.x) + timeShift.x) * range.x;
            //float y = Mathf.Cos((time * speed.y) + timeShift.y) * range.y;
            //float z = Mathf.Sin((time * speed.z) + timeShift.z) * range.z;

            //transform.localPosition = oldPosition + new Vector3(x, y, z);

            //Debug.Log("enemy spawned at " +
            //    "x " + transform.localPosition.x +
            //    "y " + transform.localPosition.y +
            //    "z " + transform.localPosition.z
            //    );

            //j++;

        }

    }

    void Update()
    {
        RandEachInstance();
    }
}
