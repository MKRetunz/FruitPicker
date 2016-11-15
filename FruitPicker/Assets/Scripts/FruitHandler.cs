using UnityEngine;
using System.Collections;

public class FruitHandler : MonoBehaviour
{
    public Transform Fruit;
    float spawnTimer;
    float spawnTime;
    bool activeFruit= false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Fruit(Clone)")
        {
            activeFruit = true;
        }
        else
        {
            activeFruit = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        spawnTime = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeFruit == false)
        {
            spawnTimer += Time.deltaTime;
            Debug.Log(spawnTimer);
        }

        if (spawnTimer >= spawnTime)
        {
            Instantiate(Fruit, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            spawnTimer = 0f;
        }
        
    }
}
