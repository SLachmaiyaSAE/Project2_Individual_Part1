using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject haters;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnHaters();
            timer = 0;
        }
    }
    void spawnHaters()
    {
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            Instantiate(haters, new Vector3(transform.position.x, Random.Range(lowestPoint = -4, highestPoint = 6), 0), transform.rotation);
        }
    }
}