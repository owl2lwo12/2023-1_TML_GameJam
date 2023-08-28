using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cats : MonoBehaviour
{
    public int dmg = 20;
    public Transform player;
    public float speed = 10f;
    private void Update()
    {
        if (player != null)
        {
            if (transform.position.x - player.position.x < 15f)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
    }
}
