using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb; // The player's rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(0f, movement * speed);
        rb.velocity = velocity;
    }
}
