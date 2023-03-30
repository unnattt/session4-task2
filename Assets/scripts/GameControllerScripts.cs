using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControllerScripts : MonoBehaviour
{
    public GameObject ball;
    public GameObject bat;

    float nextBallThrown;
    float ballThorwnRate = 4f;

    public static int ScoreValue = 0;
    public Text Runs;

    Vector2 random;
    //public LayerMask mask;
    
    void Update()
    {
        Runs.text = "Your Runs: " + ScoreValue;
        ballsThrown();
            //rayCastBat();
    }

    public void ballsThrown()
    {
        if (Time.time > nextBallThrown)
        {
            random.x = Random.Range(-4f, -2f);
            random.y = Random.Range(-4.74f,-4.74f);

            GameObject any = Instantiate(ball, ball.transform.position, ball.transform.rotation);
            ballThorwn obj = any.GetComponent<ballThorwn>();
            obj.BallForce(random);
            nextBallThrown = Time.time + ballThorwnRate;
            Destroy(any, 4f);
        }
    }
    //public void rayCastBat()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        GameObject any = bat;
    //        BatScript obj = any.GetComponent<BatScript>();

    //        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.), Vector2.zero, 10f, mousePositionmask);

    //        obj.DragBat(hit.point);
    //    }

    //}

}

