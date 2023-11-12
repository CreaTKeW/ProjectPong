using UnityEngine;

public class CollisionController : MonoBehaviour
{
    [SerializeField] private AudioSource bounceSound;
    [SerializeField] private ballMovement ballMovement;

    [SerializeField] GameObject destroyParticle;

    private void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHight = collision.collider.bounds.size.y;

        float x;

        if (collision.gameObject.name == "PlayerPaddle")
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
        if(collision.gameObject.name == "PlayerPaddle" ||  collision.gameObject.name == "EnemyPaddle")
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
