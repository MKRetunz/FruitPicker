using UnityEngine;
using System.Collections;

public class BasketHandler : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Fruit(Clone)")
        {
            Destroy(col.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
