using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public int dmg = 20;
    Rigidbody2D r2d;
    public Transform player;
    private bool isOnTheGround = false;
    private void Start()
    {
        r2d= GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(player != null)
        {
            if(transform.position.x - player.position.x < 3f)
            {
                r2d.gravityScale = 1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isOnTheGround= true;
        }
        if(collision.gameObject.tag == "Player")
        {
            if(isOnTheGround == false)
            {
                NormalMovement nM = collision.gameObject.GetComponent<NormalMovement>();
                nM.HP -= dmg;
                Destroy(gameObject);
            }
            else if(isOnTheGround == true)
            {
                //뭐 어떻게 어떻게 해서 어찌 저찌 하면 되지
            }
        }
    }
}
