using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour {

    public GameObject bigTree;
    public GameObject deadTree;
    public GameObject fireworks;
    public GameObject otherSideOfRiver;

	// Use this for initialization
	void Start () {
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Detect trigger enter on the escape: " + other.gameObject.name);
        if (other.gameObject.transform.root.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player walked through!");
            StartCoroutine(SpawnFireworks());
        }
    }

    IEnumerator SpawnFireworks()
    {
        yield return new WaitForSeconds(1.0f);

        Debug.Log("END GAME");
        //start fireworks animation
        fireworks.SetActive(true);

        yield return new WaitForSeconds(10.0f);

        //fade to black or end game sequence

    }

    public void StartTreeFalling()
    {
        //start tree falling animation
        bigTree.GetComponent<Animation>().Play();
        Debug.Log("playing animation");
        bigTree.GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
