using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {

    [SerializeField]
    private GameObject bigTree;

    [SerializeField]
    private GameObject deadTree;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggerrrrr");
        if (other.gameObject.GetComponent<Tree>() != null)
        {
            Debug.Log("Tree");
            bigTree.SetActive(false);
            Instantiate(deadTree, bigTree.transform.position, bigTree.transform.rotation);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
