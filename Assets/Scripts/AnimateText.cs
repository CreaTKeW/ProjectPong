using UnityEngine;

public class AnimateText : MonoBehaviour
{
    public float speed = 0.1f;
    public float amplitude = 5.0f;
    private float startY;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startY + amplitude * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
