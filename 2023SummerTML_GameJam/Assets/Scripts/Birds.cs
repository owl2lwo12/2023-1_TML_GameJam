using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public int dmg = 20;
    Rigidbody2D r2d;
    public Transform player;
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
}
