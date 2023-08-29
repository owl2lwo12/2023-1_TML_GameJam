using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHeal : MonoBehaviour
{
    public int HealP = 10;

    private void OnTriggerStay2D(Collider2D collision)
    {
        NormalMovement nM = collision.gameObject.GetComponent<NormalMovement>();
        if (!nM.CanHit())
        {
            nM.HP += HealP;
            nM.Hit();
        }
    }
}
