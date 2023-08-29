using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalMovement : MonoBehaviour
{
    public float padakpadak = 4f;
    private Rigidbody2D rb;
    public float spd = 5f;
    public int HP = 100;
    private bool isHit = false;
    public float timer = 1f;
    public GameObject uipanel;
    private void Awake()
    {
        if(Time.timeScale== 0)
        {
            Time.timeScale = 1;
        }
        rb = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, padakpadak, 0);
        padakpadak = 4f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            Jump();
        }
        if(collision.gameObject.tag == "Obstacle")
        {
            isHit = true;
            Jump();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NextStage")
        {
            SceneManager.LoadScene(1);
        }
    }
    private void Update()
    {
        if (isHit)
        {
            timer -= Time.deltaTime;

        }
        if(timer <= 0f)
        {
            isHit = false;
            timer = 1f;
        }


        if (Input.GetKey(KeyCode.W))
        {
            padakpadak = 10f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveTo(1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoveTo(-1);
        }


        if(HP <= 0f)
        {
            //gameover
            uipanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void MoveTo(int t)
    {
        transform.Translate(Vector3.left * t * spd * Time.deltaTime);
    }

    public void Hit()
    {
        isHit = true;
    }

    public bool CanHit()
    {
        return isHit;
    }
}
