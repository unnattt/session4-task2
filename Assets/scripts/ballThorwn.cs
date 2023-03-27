using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThorwn : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
   public  void BallForce()
    {
        Rigidbody2D ball = GetComponent<Rigidbody2D>();
        ball.AddForce(Vector2.left * speed);
    }


}
