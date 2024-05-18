using UnityEngine;

public class ZombieBehavior : MonoBehaviour
{
    // The player entity to follow
    [SerializeField] Transform snake;

    // The speed at which the zombie moves
    public float moveSpeed = 5.0f;

    // The distance at which the zombie stops following the player
    public float stopDistance = 1.0f;

    private void Update()
    {
        // Calculate the direction from the zombie to the player
        Vector3 direction = (snake.position - transform.position).normalized;

        // Move the zombie towards the player
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        // Check if the zombie is close enough to the player
        if (Vector3.Distance(transform.position, snake.position) < stopDistance)
        {
            // Stop moving if the zombie is close enough
            moveSpeed = 0.0f;
        }
        else
        {
            // Resume moving if the zombie is not close enough
            moveSpeed = 2.0f;
        }
    }
}