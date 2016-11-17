using UnityEngine;
using System.Collections;

public class BasketHandler : MonoBehaviour {
    public static int score;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Fruit(Clone)")
        {
            Destroy(col.gameObject);
            score++;
            Debug.Log(score);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
