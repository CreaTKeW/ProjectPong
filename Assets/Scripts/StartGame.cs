using UnityEngine;
public class StartGame : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject ball;

    void Start()
    {
        ball.SetActive(false);
        this.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ball.SetActive(true);
            audioSource.Play();
            this.gameObject.SetActive(false);           
        }
    }
}
