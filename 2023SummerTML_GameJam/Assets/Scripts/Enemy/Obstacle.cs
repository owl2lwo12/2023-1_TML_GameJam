using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int dmg = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NormalMovement nM = collision.gameObject.GetComponent<NormalMovement>();
        if (!nM.CanHit())
        {
            nM.HP -= dmg;
            nM.Hit();
            //추가 상태이상
        }
    }
}
