using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScriptRaycast: MonoBehaviour
{
	// Start is called before the first frame update
	void Start(){

	}

	// Update is called once per frame
	void Update(){
		// first, let's check if the mouse button was clicked
		// again we can specify which button we mean. "0" stands for left-click
		if(Input.GetMouseButtonDown(0)){
			// create the ray from mouse position at the main camera
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// check what the ray is hitting
			if(Physics.Raycast(ray, out RaycastHit target)){
				// check if the target is the object that this script is attached to
				// by comparing the transforms of target.transform and our transform
				if(target.transform == transform){
					// if yes, then rotate it
                    transform.Rotate(42.0f, 0.0f, 0.0f);
				}
			}
		}
	}
}
