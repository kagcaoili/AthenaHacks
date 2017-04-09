using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    private EndingManager endgame;

    public static bool fireOn = false;
    public static bool waterOn = false;

    public static int taskCount = 0;

    private bool endBegins = false;

    [SerializeField]
    private int MAX_TASKS = 2;

	// Use this for initialization
	void Start () {
        endgame = gameObject.GetComponent<EndingManager>();
        Debug.Log("set endgame");

        //endgame.StartEndScene();
	}
	
	// Update is called once per frame
	void Update () {
        if (!endBegins)
        {
            if (fireOn && waterOn) 
            {
                endBegins = true;
                endgame.StartTreeFalling();
            }
        }
		
	}
}
