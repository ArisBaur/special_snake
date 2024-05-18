using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeController_aris : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // movement speed of the snake
    [SerializeField] private float turnSpeed = 90f; // turning speed of the snake
    private int turnDir;
    private int size = 1;
    private float current_size = 1;


    private void Update()
    {
        turnDir = (int)Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    private void FixedUpdate()
    {
        //rotate
        transform.Rotate(0, turnDir * turnSpeed, 0);
        //translate
        transform.Translate(0, 0, speed);
    }


    public void eat()
    {
        size += 1;
        current_size = Mathf.Pow(0.99f, size) / 24;
        speed += current_size;
        transform.localScale += new Vector3(current_size, current_size, current_size);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DEATH") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}