using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berry : VRTK_InteractableObject {

	private static int berriesEaten = 0;

	// Use this for initialization
	void Start () {

	}

	public override void StartUsing(GameObject usingObject) {

		base.StartUsing (usingObject);
	}

	public override void StopUsing(GameObject usingObject) {

		base.StopUsing (usingObject);
	}

	void Update() {
		if (IsGrabbed ()) {
			berriesEaten++;
			//add eating noise here maybe
			Debug.Log("berries eaten: " + berriesEaten);
			Destroy (this);
		}

		if (berriesEaten == 10) { // end task
			// +1 task script here
			Debug.Log("you've eaten ten berries! you're done");
		}
	}
		
}
