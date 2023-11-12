using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform ball;

    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;

    void Update()
    {
        if (ball != null)
        {
            Vector2 direction = ball.transform.position - transform.position;
            direction.x = 0;

            float targetY = Mathf.Clamp(ball.transform.position.y, minHeight, maxHeight);
            Vector3 targetPosition = new Vector3(transform.position.x, targetY, transform.position.z);

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }        
    }
}
