using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform player;
    public GameObject car;
    public bool plusORminus = true;
    private float interval;
    private float speed;
    public float pos = 0;

    private void Start()
    {
        interval = Random.Range(2, 5);
    }
    private float timer = 0f;
    private void Update()
    {
        if((int)(player.position.y + pos)%2 == 0)
        {
            plusORminus = true;
        }
        else
        {
            plusORminus= false;
        }
        timer += Time.deltaTime;

        if (timer >= interval)
        {   
            if(plusORminus)
            {
                SpawnEnemy(1);
            }
            else
            {
                SpawnEnemy(-1);
            }
            timer = 0f;
        }
    }

    private void SpawnEnemy(float t)
    {
        Vector3 v = new Vector3(10 * t + player.position.x, player.position.y + pos, 0f);
        GameObject p = Instantiate(car, v, Quaternion.identity);
        speed = Random.Range(3.5f, 6.5f);
        Drive pp = p.GetComponent<Drive>();
        speed *= t;
        pp.MakeSetting(speed);
    }
}
