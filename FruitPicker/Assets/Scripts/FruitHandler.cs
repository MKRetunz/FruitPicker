using UnityEngine;
using System.Collections;

public class FruitHandler : MonoBehaviour
{
    public Transform Fruit;
    private GameObject[] fruitList;
    float spawnTimer;
    float spawnTime;
    bool activeFruit= false;

    // Use this for initialization
    void Start()
    {
        fruitList = new GameObject[1] { Instantiate(Fruit, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity) as GameObject };
        spawnTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fruitList == null)
        {
            spawnTimer += Time.deltaTime;
            Debug.Log("Heya");
        }

        if (spawnTimer >= spawnTime)
        {
            fruitList[0] = Instantiate(Fruit, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity) as GameObject;
            
            spawnTimer = 0f;
        }
        
    }
}
