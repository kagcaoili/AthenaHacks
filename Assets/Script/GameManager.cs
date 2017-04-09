using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    private EndingManager endgame;

    public static bool fireOn = false;
    public static bool waterOn = false;

    public static int taskCount = 0;

    private bool endBegins = false;

    public GameObject canvas;

    [SerializeField]
    private int MAX_TASKS = 2;

	// Use this for initialization
	void Start () {
        endgame = gameObject.GetComponent<EndingManager>();
        Debug.Log("set endgame");

        StartCoroutine(Beginning());

        //endgame.StartEndScene();
	}

    IEnumerator Beginning()
    {
        Win obj = canvas.GetComponentInChildren<Win>();
        Text objText = obj.gameObject.GetComponent<Text>();
        
        if (!fireOn && !waterOn)
        {
            objText.text = "0";
        } else if (!fireOn || !waterOn)
        {
            objText.text = "1";
        } else if (fireOn && waterOn)
        {
            objText.text = "2";
        }


        canvas.SetActive(true);
        yield return new WaitForSeconds(7.0f);
        canvas.SetActive(false);
        yield return null;
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
