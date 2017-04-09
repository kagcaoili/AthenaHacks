using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour {

	bool stickEntered = false;
	int stickNumber = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) {
			stickEntered = true;
			stickNumber++;
			Debug.Log("stick entered " + stickNumber);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) {
			stickEntered = false;
			stickNumber--;
		}
	}

	bool getStickEntered() {
		return stickEntered;
	}

	int getStickNumber() {
		return stickNumber;
	}
}