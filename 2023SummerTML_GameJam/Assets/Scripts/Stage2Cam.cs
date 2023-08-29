using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Cam : MonoBehaviour
{
    public Transform player;
    private void Update()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.position.x, player.position.y +3f, -10);
        }
    }
}
