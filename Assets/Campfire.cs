using VRTK;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Campfire : MonoBehaviour {

	bool stickEntered = false;
	int stickNumber = 0;
	GameObject stick;

    public GameObject canvas;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) { // if it's a stick
			stick = other.gameObject;
			stick.GetComponent<Stick>().setCounting (true); // stick in fire trigger, start counting
			if (stick.GetComponent<Stick>().fireStarted ()) { // if sticks start fire
				// enable children of this campfire
				GameObject MyObjName = GameObject.Find("Campfire");
				foreach (Transform child in MyObjName.transform)
				{
					child.gameObject.SetActive(true);
				}

                //play sound effect here
                GameManager.fireOn = true;
                Debug.Log("fire task is now: " + GameManager.fireOn);
                StartCoroutine(Beginning());
			}
		}
	}

    IEnumerator Beginning()
    {
        Win obj = canvas.GetComponentInChildren<Win>();
        Text objText = obj.gameObject.GetComponent<Text>();

        if (!GameManager.fireOn && !GameManager.waterOn)
        {
            objText.text = "0";
        }
        else if (!GameManager.fireOn || !GameManager.waterOn)
        {
            objText.text = "1";
        }
        else if (GameManager.fireOn && GameManager.waterOn)
        {
            objText.text = "2";
        }


        canvas.SetActive(true);
        yield return new WaitForSeconds(7.0f);
        canvas.SetActive(false);
        yield return null;
    }

    void OnTriggerExit(Collider other) {
		if (other.gameObject.GetComponent<Stick>() != null) {
			stick.GetComponent<Stick>().resetStickCount();
			stick.GetComponent<Stick>().setCounting (false);
		}
	}

	bool getStickEntered() {
		return stickEntered;
	}

	int getStickNumber() {
		return stickNumber;
	}
}