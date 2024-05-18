using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController_aris : MonoBehaviour
{
    private float speed = 5f; // movement speed of the snake
    private float turnSpeed = 90f; // turning speed of the snake

    void Update()
    {
        // check for key input
        if (Input.GetKey(KeyCode.A))
        {
            // turn the snake left
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // turn the snake right
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }

        // move the snake
        transform.Translate(0, 0, speed * Time.deltaTime);

        //// make the snake move in the direction it is facing
        //Vector3 moveDirection = transform.forward;
        //GetComponent<Rigidbody>().velocity = moveDirection * speed;
    }
}