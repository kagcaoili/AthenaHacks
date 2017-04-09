using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour {

	bool stickEntered = false;
	int stickNumber = 0;
	GameObject stick;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) {
			stick = other.gameObject;
			stick.GetComponent<Stick>().resetStickCount();
			Debug.Log ("reset stick count, fire = false");
			if (stick.GetComponent<Stick>().fireStarted ()) { // if sticks start fire
				// enable children of this campfire
				GameObject MyObjName = GameObject.Find("Campfire");
				foreach (Transform child in MyObjName.transform)
				{
					child.gameObject.SetActive(true);
				} 
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) {
			stick.GetComponent<Stick>().resetStickCount();
		}
	}

	bool getStickEntered() {
		return stickEntered;
	}

	int getStickNumber() {
		return stickNumber;
	}
}