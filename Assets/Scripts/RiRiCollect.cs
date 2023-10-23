using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiRiMovement : MonoBehaviour
{

    public float moveSpeed = 6;

    public Logic logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();

        if (gameObject.CompareTag("addscore"))
        {
            Destroy(gameObject);
        }
    }
}
