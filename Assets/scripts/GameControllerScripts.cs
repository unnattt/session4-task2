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
   public  GameObject pointer;
    //public LayerMask mask;
    //public RaycastHit hitting;

    //private void Start()
    //{

    //}

    void Update()
    {
        Runs.text = "Run: " + ScoreValue;
        ballsThrown();
            //rayCastBat();
    }

    public void ballsThrown()
    {
        if (Time.time > nextBallThrown)
        {
            random.x = Random.Range(-4f, 0f);
            random.y = Random.Range(-4.74f,-4.74f);
            pointer.transform.position = random;

            GameObject any = Instantiate(ball, ball.transform.position, ball.transform.rotation);
            ballThorwn obj = any.GetComponent<ballThorwn>();
            obj.BallForce(pointer.transform.position);
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

