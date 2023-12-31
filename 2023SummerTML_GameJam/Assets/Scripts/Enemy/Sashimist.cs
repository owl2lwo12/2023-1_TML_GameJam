using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sashimist : MonoBehaviour
{
    public float speed = 3f;
    public GameObject uipanel;

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            uipanel.SetActive(true);
            Time.timeScale = 0;//GameOver
        }
    }
}
