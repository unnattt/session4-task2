using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatScript : MonoBehaviour
{

   [SerializeField] Rigidbody2D bat;
    bool isMouseClick;

    // public void Start()
    //{
    //    bat = GetComponent<Rigidbody2D>();
    //}

    // public void DragBat(Vector2 point)
    //{
    //    Rigidbody2D bats = GetComponent<Rigidbody2D>();
    //    bats.MovePosition(point);
    //}
    //private void OnMouseDown()
    //{
    //    isMouseClick = true;
    //}

    //private void OnMouseUp()
    //{
    //    isMouseClick = false;
    //}


    private void OnMouseEnter()
    {
        isMouseClick = true;
    }
    private void OnMouseExit()
    {
        isMouseClick = false;
    }
    public void OnMouseDrag()
    {
        if (isMouseClick == true)
        {
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bat.MovePosition(dir);
        }
    }
}
       

    