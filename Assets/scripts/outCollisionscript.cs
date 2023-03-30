using UnityEngine;


public class outCollisionscript : MonoBehaviour
{
    public GameObject panel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        panel.SetActive(true);
    }
}
