using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public AudioSource bounceSound;
    public ballMovement ballMovement;

    [SerializeField] GameObject destroyParticle;

    void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHight = collision.collider.bounds.size.y;

        float x;

        if (collision.gameObject.name == "Player")
        {
            x = 1;
        }
        else { x = -1; }

        float y = (ballPosition.y - racketPosition.y) / racketHight;
        
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "PlayerField" || collision.gameObject.name == "AIField")
        {           
            Instantiate(destroyParticle, transform.position, transform.rotation);
            StartCoroutine(ballMovement.StartBall());            
        }       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player" ||  collision.gameObject.name == "AI")
        {
            bounceSound.Play();
            this.BounceFromRacket(collision);
        }

        if (collision.gameObject.name == "TopWall" || collision.gameObject.name == "BottomWall")
        {
            bounceSound.Play();
            ballMovement.IncreaseHitCounter();
        }
    }
}
