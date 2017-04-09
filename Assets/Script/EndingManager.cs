using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour {

    public GameObject bigTree;
    public GameObject deadTree;

	// Use this for initialization
	void Start () {
        
	}

    IEnumerator SpawnFireworks()
    {
        yield return new WaitForSeconds(2.0f);

        Debug.Log("StartTree");
        StartTreeFalling();
        //start fireworks animation

        yield return new WaitForSeconds(10.0f);

        //fade to black or end game sequence

    }

    public void StartEndScene()
    {
        StartCoroutine(SpawnFireworks());
    }

    public void StartTreeFalling()
    {
        //start tree falling animation
        bigTree.GetComponent<Animation>().Play();
        Debug.Log("playing animation");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
