using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnGUI ()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + BasketHandler.score);
        Debug.Log(BasketHandler.score);
       
    }
}
