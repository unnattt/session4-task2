using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBallThrown : MonoBehaviour
{
    Rigidbody2D rb;
    public float Force;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void BallForce()
    {
        Rigidbody2D ball = GetComponent<Rigidbody2D>();
        ball.AddForce(Vector2.left * Force);
    }
}
