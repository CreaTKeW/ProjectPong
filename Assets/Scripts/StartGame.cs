using UnityEngine;
public class StartGame : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball.SetActive(false);
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ball.SetActive(true);
            audioSource.Play();
            gameObject.SetActive(false);           
        }
    }
}
