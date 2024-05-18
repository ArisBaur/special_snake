using UnityEngine;

public class ZombieBehavior : MonoBehaviour
{

    GameObject snake;
    public float moveSpeed = 5.0f;

    private void Start()
    {
        snake = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        Vector3 direction = (snake.transform.position - transform.position).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == snake)
        {
            Destroy(gameObject);
            snake.GetComponent<SnakeController_aris>().eat();
        }
    }

}