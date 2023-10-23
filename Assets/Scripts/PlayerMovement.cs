using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveStrength;
    public float horizontal;
    public Logic logic;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector3.up * moveStrength;
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            myRigidbody.velocity = Vector2.right * moveStrength;
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            myRigidbody.velocity = Vector2.left * moveStrength;
        }

    }
        
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            logic.gameOverScreen();
        }
    }
}

