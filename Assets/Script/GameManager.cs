using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    private EndingManager endgame;


    [SerializeField]
    private GameObject bigTreeSet;

    [SerializeField]
    private GameObject deadTreeSet;

    private int taskCount = 0;

    [SerializeField]
    private int MAX_TASKS = 1;

	// Use this for initialization
	void Start () {
        endgame = new EndingManager();
        endgame.bigTree = bigTreeSet;
        Debug.Log("set endgame");
        //endgame.deadTree = deadTreeSet;

        //endgame.StartTreeFalling();
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
