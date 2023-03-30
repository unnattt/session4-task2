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
 

    public  void BallForce(Vector2 pos)
    {
        Rigidbody2D ball = GetComponent<Rigidbody2D>();
        // ball.AddForce((pos - (Vector2)transform.position) * Force);
        Vector2 target = (pos - (Vector2)transform.position).normalized;
        Debug.Log("target " + target);
        ball.velocity = target * speed;
        
       
       // ball.AddForce(target * force);
    }


}
