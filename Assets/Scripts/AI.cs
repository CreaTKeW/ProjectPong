using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed;
    public Transform ball;
    private float distance;

    public float minHeight;
    public float maxHeight;

    void Update()
    {
        if (ball != null)
        {
            distance = Vector2.Distance(transform.position, ball.transform.position);
            Vector2 direction = ball.transform.position - transform.position;
            direction.x = 0;

            // Set the desired height within the limits
            float targetY = Mathf.Clamp(ball.transform.position.y, minHeight, maxHeight);
            Vector3 targetPosition = new Vector3(transform.position.x, targetY, transform.position.z);

            // Move towards the target position
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }        
    }
}
