using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnScript : MonoBehaviour
{
    public GameObject ground;
    public GameObject ground2;
    public GameObject ground3;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnGround();
            timer = 0;
        }
    }
    void spawnGround()
    { 
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            Instantiate(ground, new Vector3(transform.position.x, Random.Range(lowestPoint = -3, highestPoint = 4), 0), transform.rotation);
            Instantiate(ground2, new Vector3(transform.position.x, Random.Range(lowestPoint = -5, highestPoint = 6), 0), transform.rotation);
            Instantiate(ground3, new Vector3(transform.position.x, Random.Range(lowestPoint = -5, highestPoint = 7), 0), transform.rotation);
        }
    }
}
