using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {
    float playTimer;
    float maxTime;

    // Use this for initialization
    void Start () {
        maxTime =   120f;
        playTimer = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        playTimer -= Time.deltaTime;

        
	}

    void OnGUI ()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + BasketHandler.score);
        GUI.Label(new Rect(Screen.width / 2, Screen.height - 40 , 100, 20), playTimer.ToString("0"));
    }
}
