using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WaterScript : VRTK_InteractableObject {
	
	//public Color blue;
	//MeshRenderer ren;
	//public Texture txtr;

	// Use this for initialization
	void Start () {
		//ren = GetComponent<MeshRenderer> ();
	}

    public override void StartUsing(GameObject usingObject)
    {

        base.StartUsing(usingObject);
    }

    public override void StopUsing(GameObject usingObject)
    {

        base.StopUsing(usingObject);
    }

    protected override void Update()
    {
        base.Update();
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Trigger Exit Bottle!");
        if (IsGrabbed())
        {
            Debug.Log("Exit and you are grabbing something!");
            if (other.gameObject.GetComponent<River>() != null)
            {
                Debug.Log("Get compoenent river! its a river!");
                GameManager.waterOn = true;
                Debug.Log("the water task is now: " + GameManager.waterOn);
                Debug.Log("that bottle dippity dip");
            }
        
            
        }
		
	}
}
