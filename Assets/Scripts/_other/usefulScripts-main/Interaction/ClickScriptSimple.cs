using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScriptSimple: MonoBehaviour
{
	// Start is called before the first frame update
	void Start(){

	}

	// Update is called once per frame
	void Update(){
		// check if the mouse button with index "0" is currently hold down
        // basically, this is just left-click.
		if(Input.GetMouseButtonDown(0)){
            // if the mouse button is currently hold down, we do something.
            // we could rotate the object to which this script is attached, why not?
            transform.Rotate(10.0f,10.0f,10.0f);

            // uncomment the following line to also move it around
            //transform.Translate(1.0f,0.0f,0.0f);
		}
	}
}
