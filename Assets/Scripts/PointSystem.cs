using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    [SerializeField] private AudioSource scoreSound;
    [SerializeField] private Text AIScoreText;
    [SerializeField] private Text PlayerScoreText;

    [SerializeField] private int PlayerScore;
    [SerializeField] private int AIScore;
    [SerializeField] private int maxScore = 5; 

    private void UpdateScore()
    {
        AIScoreText.text = "" + AIScore;
        PlayerScoreText.text = "" + PlayerScore;
    }   

    void FixedUpdate()
    {
        UpdateScore();

        if(AIScore >= maxScore)
        {
            SceneManager.LoadScene(3);
        }

        if (PlayerScore >= maxScore)
        {
            SceneManager.LoadScene(4);
        }
    }

    private void AddScore(int addScore)
    {
        if(addScore == 1)
        {
            PlayerScore++;           
        }

        else if(addScore == 2)
        {
            AIScore++;
        }     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "AIField") 
        {
            scoreSound.Play();
            AddScore(1);
        }

        if (collision.gameObject.name == "PlayerField")
        {
            scoreSound.Play();
            AddScore(2);
        }
    }

}
