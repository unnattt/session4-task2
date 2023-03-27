using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScripts : MonoBehaviour
{
    public GameObject ball;
    public GameObject bat;

    public LayerMask mask;
    public RaycastHit hitting;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballsThrown();
        }
    }

    public void ballsThrown()
    {
        GameObject any = Instantiate(ball, ball.transform.position, ball.transform.rotation);
        ballThorwn obj = any.GetComponent<ballThorwn>();
        obj.BallForce();
        Destroy(any, 3f);
    }

    //public void rayCastBat()
    //{
    //    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.))
    //    //Debug.Log(ray);

    //    if (Physics.Raycast(ray, out hitting, 60f, mask))
    //    {


    //        if (Input.GetMouseButtonDown(0))
    //        {

    //        }

    //    }
    //}
}

