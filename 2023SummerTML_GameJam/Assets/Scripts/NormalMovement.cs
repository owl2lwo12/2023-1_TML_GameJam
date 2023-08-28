using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement : MonoBehaviour
{
    public float padakpadak = 4f;
    private Rigidbody2D rb;
    public float spd = 5f;
    public int HP = 100;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Jump()
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
    }
    private void Update()
    {
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
    }

    private void MoveTo(int t)
    {
        transform.Translate(Vector3.left * t * spd * Time.deltaTime);
    }
}
