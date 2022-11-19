using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScriptLeftRight: MonoBehaviour
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
            transform.Translate(1.0f,0.0f,0.0f);
		}
        // check if the mouse button with index "1" is currently hold down
        // basically, this is just right-click
		if(Input.GetMouseButtonDown(1)){
            // if the mouse button is currently hold down, we do something.
            // we could rotate the object to which this script is attached, why not?
            transform.Rotate(10.0f,42.0f,10.0f);

            // uncomment the following line to also move it around
            // here, pay attention that we add another parameter "Space.World"
            // to make sure that the object moves in "World Space"
            // and is not affected by its own rotation
            transform.Translate(1.0f,0.0f,0.0f,Space.World);
		}
	}
}
