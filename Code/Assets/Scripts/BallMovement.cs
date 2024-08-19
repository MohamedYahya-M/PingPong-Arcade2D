using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ballRb;
  
    [SerializeField] float startTime ;
    [SerializeField] float ballSpeed;
    [SerializeField] float maxBallSpeed;
    [SerializeField] float speedIncreasePerHit;

    int hitCounter = 0;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        
        StartCoroutine(StartBall());

    }

    public void RepositionBall(bool isStartingPlayer1)
    {
        ballRb.velocity = Vector3.zero;
        if(isStartingPlayer1) 
        {
            transform.localPosition = new Vector3(-2, 1.5f, 0);
        }
        else
        {
            transform.localPosition = new Vector3(2, 1.5f, 0);
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = ballSpeed + hitCounter * speedIncreasePerHit;
        ballRb.velocity = direction * speed;
    }
    
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {

        RepositionBall(isStartingPlayer1);
        yield return new WaitForSeconds(startTime);
        hitCounter = 0;
        if (isStartingPlayer1)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
       
    }

 

    public void IncreaseHitCount()
    {
        if(hitCounter * speedIncreasePerHit <= maxBallSpeed)
        {
            hitCounter++;
        }
    }

  
}
