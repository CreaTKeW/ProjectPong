using System.Collections;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private TrailRenderer trailRenderer;

    [SerializeField] private float speed;
    [SerializeField] private float addSpeed;
    [SerializeField] private float maxSpeed;

    private int hitCounter = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(this.StartBall());   
    }

    private void PositionBall()
    {
        trailRenderer.enabled = false;
        rb.velocity = new Vector2(0, 0);
        gameObject.transform.localPosition = new Vector3(2.34f, 0, 0);
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall();
        this.hitCounter = 0;
        yield return new WaitForSeconds(1);
        trailRenderer.enabled = true;
        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else { this.MoveBall(new Vector2(1, 0)); }
    }    

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float speed = this.speed + this.hitCounter * this.addSpeed;
       
        rb.velocity = direction * speed;
    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.addSpeed < this.maxSpeed)
        {
            this.hitCounter++;
        }
    }
}
