using UnityEngine;

public class AnimateText : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float amplitude = 5.0f;
    private float startY;


    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        float newY = startY + amplitude * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
