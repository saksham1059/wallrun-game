using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction to the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Ignore gravity by setting the y-component to zero
            direction.y = 0;

            // Move the enemy towards the player
            MoveTowardsPlayer(direction);

            // Rotate to face the player (optional)
            RotateTowardsPlayer(direction);
        }
    }

    void MoveTowardsPlayer(Vector3 direction)
    {
        // Raycast to check for obstacles with the tag "dontgoout"
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity) && hit.collider.CompareTag("dontgoout"))
        {
            // If there's an obstacle, stop moving
            return;
        }

        // Move the enemy
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void RotateTowardsPlayer(Vector3 direction)
    {
        Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, 10f * Time.deltaTime);
    }
}
