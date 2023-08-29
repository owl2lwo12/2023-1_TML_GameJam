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
            NormalMovement nM = collision.gameObject.GetComponent<NormalMovement>();
            if (isOnTheGround == false)
            {
                if (!nM.CanHit())
                {
                    nM.HP -= dmg;
                    nM.Hit();
                    //추가 상태이상
                }
                Destroy(gameObject);
                
            }
            else if(isOnTheGround == true)
            {
                nM.Jump();
                //뭐 어떻게 어떻게 해서 어찌 저찌 하면 되지
            }
        }
    }
}
