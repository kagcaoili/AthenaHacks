using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    private EndingManager endgame;

    private int taskCount = 0;

    [SerializeField]
    private int MAX_TASKS = 1;

	// Use this for initialization
	void Start () {
        endgame = gameObject.GetComponent<EndingManager>();
        Debug.Log("set endgame");

        endgame.StartEndScene();
	}

    public void IncrementTaskCount()
    {
        if (taskCount < MAX_TASKS)
        {
            taskCount++;
        }

        if (taskCount == MAX_TASKS)
        {
            endgame.StartTreeFalling();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
