using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourBoundary : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameControllerScripts.ScoreValue += 4;
    }
}
