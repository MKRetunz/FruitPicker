using UnityEngine;
using System.Collections;

public class FruitHandler : MonoBehaviour
{
    public Transform Fruit;
    float spawnTimer;
    float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnTime)
        {
            Instantiate(Fruit, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            spawnTimer = 0f;
        }
    }
}
