using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScripts : MonoBehaviour
{
    public GameObject ball;
    public GameObject bat;

    float nextBallThrown;
    float ballThorwnRate = 4f;
    //public LayerMask mask;
    //public RaycastHit hitting;

    //private void Start()
    //{

    //}

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
            ballThorwn obj = any.GetComponent<ballThorwn>();
            obj.BallForce();
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

    //        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10f, mask);

    //        obj.DragBat(hit.point);
    //    }

    //}

}

