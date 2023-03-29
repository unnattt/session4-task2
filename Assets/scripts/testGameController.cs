using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGameController : MonoBehaviour
{ 
    public GameObject ball;
    public GameObject bat;

    float nextBallThrown;
    float ballThorwnRate = 4f;

    void Update()
    {

        ballsThrown();
        //rayCastBat();
    }

    public void ballsThrown()
    {
        if (Time.time > nextBallThrown)
        {
            

            GameObject any = Instantiate(ball, ball.transform.position, ball.transform.rotation);
            testBallThrown obj = any.GetComponent<testBallThrown>();
            obj.BallForce();
            nextBallThrown = Time.time + ballThorwnRate;

            Destroy(any, 4f);
        }
    }
}
