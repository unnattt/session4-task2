using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixBoundary : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameControllerScripts.ScoreValue += 6;
    }

}
