using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMovementSimple : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Since the object should float, we need to animate the object's position with time.
        //
        // So we need to know how late it is, let's do that first.
        // we can get the time (as in the amount of seconds since the application started)
        // like this:
        float time = Time.time;

        // we can smoothly move something by using "Sin"
        // the last number multiplies how much the object should be moved
        // 
        // there is an explanation on wikipedia: https://en.wikipedia.org/wiki/Sine_and_cosine
        // or of course also on youtube with fancy animations: https://www.youtube.com/watch?v=mhd9FXYdf4s
        float moveUpAndDown = Mathf.Sin(time) * 1.0f;

        // then use that to translate (a.k.a. move) on the y-axis
        // if we leave 0 for x and z values, it only moves up and down
        transform.Translate(0,moveUpAndDown,0);
    }
}
