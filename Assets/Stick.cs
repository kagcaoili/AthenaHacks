using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : VRTK_InteractableObject {

	bool isUsed = false;
	int counter = 0;
	bool hasFire = false;

	// Use this for initialization
	void Start () {
		
	}

	public override void StartUsing(GameObject usingObject) {

		base.StartUsing (usingObject);
		isUsed = true;
	}

	public override void StopUsing(GameObject usingObject) {

		base.StopUsing (usingObject);
		isUsed = false;
		counter = 0;
	}

	protected override void Update() {
		base.Update();
		if (counter == 3) {
			Debug.Log ("fire");
			hasFire = true;
		}
	}

	public bool stickIsHeld() {
		return isUsed;
	}

	void OnCollisionEnter(Collision other) {
		if (IsGrabbed ()) {
			if (other.gameObject.GetComponent<Stick> () != null) { // is a stick
				counter++;
			}
		}
	}

	public bool fireStarted() {
		return hasFire;
	}

	public void resetStickCount() {
		counter = 0;
	}
}
