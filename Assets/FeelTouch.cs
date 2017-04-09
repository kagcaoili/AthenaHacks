using VRTK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeelTouch : VRTK_InteractableObject {

	// Use this for initialization
	void Start () {
		if (IsTouched ()) {
			Debug.Log ("You win");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
