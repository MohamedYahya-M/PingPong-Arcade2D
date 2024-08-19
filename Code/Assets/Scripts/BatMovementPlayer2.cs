using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovementPlayer2 : MonoBehaviour
{
    private Rigidbody2D playerRb;
    [SerializeField] float moveBatSpeed = 3f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical2") * moveBatSpeed;
        Vector2 playerVelocity = new Vector2(playerRb.velocity.x, verticalInput);
        playerRb.velocity = playerVelocity;
    }
}
