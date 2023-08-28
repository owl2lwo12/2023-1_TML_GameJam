using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    private void Update()
    {
        if (player != null)
        {
            transform.position= new Vector3(player.position.x,0,-10);
        }
    }
}
