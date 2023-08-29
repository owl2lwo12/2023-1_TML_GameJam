using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private float speed = 0;
    private float timer = 0f;
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer > 7f) Destroy(gameObject);
    }
    public void MakeSetting(float setspeed)
    {
        speed = setspeed;
    }
}
