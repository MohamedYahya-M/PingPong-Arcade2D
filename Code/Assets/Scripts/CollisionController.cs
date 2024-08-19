using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void Start()
    {
        
    }

    private void Update()
    {
        
    }


    private void BounceFromBat(Collision2D collision)
    {
        Vector2 ballPosition = transform.position;
        Vector2 batPosition = collision.transform.position;

        float batHeight = collision.collider.bounds.size.y;

        float x;

        if(collision.gameObject.name == "Player 1 Bat")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - batPosition.y) / batHeight;
        ballMovement.IncreaseHitCount();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1 Bat" || collision.gameObject.name == "Player 2")
        {
            BounceFromBat(collision);
        }
        else if (collision.gameObject.name == "Right-Wall")
        {
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "Left-Wall")
        {
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}
