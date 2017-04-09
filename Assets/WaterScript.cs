using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour {
	
	public Color blue;
	MeshRenderer ren;
	public Texture txtr;

	// Use this for initialization
	void Start () {
		ren = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerExit(Collider other) {
		Material currmat = ren.material;
		Material newmat = new Material (currmat);
		newmat.SetColor ("_Color", blue);
		ren.material = newmat;

		ren.material.mainTexture = txtr;

		Debug.Log ("that bottle dippity dip");
	}
}
