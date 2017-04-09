using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : VRTK_InteractableObject {

	bool isUsed = false;
	int counter = 0;
	bool hasFire = false;
	bool startCounting = false;

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
	}

	public bool stickIsHeld() {
		return isUsed;
	}

	void OnCollisionEnter(Collision other) {
		if (IsGrabbed ()) {
			if (other.gameObject.GetComponent<Stick> () != null) { // is a stick
				if (startCounting) { // only counts when in trigger
					counter++;
                    //Debug.Log ("count: " + counter);

                    GetComponent<AudioSource>().Play();
				}
			}
		}
	}

	public bool fireStarted() {
		if (counter >= 3) {
			return true;
		}
		return false;
	}

	public void resetStickCount() {
		counter = 0;
	}

	public void setCounting(bool booleanValue) {
		startCounting = booleanValue;
		Debug.Log ("startCounting = " + booleanValue);
	}
}
