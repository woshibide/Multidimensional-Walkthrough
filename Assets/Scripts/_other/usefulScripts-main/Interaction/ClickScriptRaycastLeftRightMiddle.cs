using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScriptRaycastLeftRightMiddle: MonoBehaviour
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
					// if yes, then push it away
                    transform.Translate(ray.direction);
				}
			}
		}

		// then, let's check if the other mouse button was clicked
		// again we can specify which button we mean. "1" stands for right-click
		if(Input.GetMouseButtonDown(1)){
			// create the ray from mouse position at the main camera
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// check what the ray is hitting
			if(Physics.Raycast(ray, out RaycastHit target)){
				// check if the target is the object that this script is attached to
				// by comparing the transforms of target.transform and our transform
				if(target.transform == transform){
					// if yes, then pull it towards us
                    // by multiplying the ray direction with -1 and therefore turn it around
                    transform.Translate(-1 * ray.direction);
				}
			}
		}

		// then, let's check if the middle mouse button was clicked
		// again we can specify which button we mean. "2" stands for middle-click
		if(Input.GetMouseButtonDown(2)){
			// create the ray from mouse position at the main camera
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// check what the ray is hitting
			if(Physics.Raycast(ray, out RaycastHit target)){
				// check if the target is the object that this script is attached to
				// by comparing the transforms of target.transform and our transform
				if(target.transform == transform){
					// if yes, then add a rigid body,
                    // so it is affected by gravity and falls down
                    // soooo, let's get the Rigidbody component that is attached to the object
                    Rigidbody rb = GetComponent<Rigidbody>();

                    // if there is no Rigidbody attached to it, then "rb" is empty and therefore "false"
                    if (rb == false) { // same as "if (!br) {", but maybe this is clearer
                        // so, there is indeed no Rigidbody yet,
                        // let's add it. "gameObject" is the object that this script is attached to
                        rb = gameObject.AddComponent<Rigidbody>();
                    } else { // else means, that "rb" is not false, so it exists!
                        // if we can attach something, we can also take it away again
                        // by using 'Destroy'. Sounds drastic, but works fine:
                        Destroy(rb);
                    }
				}
			}
		}
	}
}
