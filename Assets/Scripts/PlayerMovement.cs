using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(0f, movement * speed);
        rb.velocity = velocity;
    }
}
