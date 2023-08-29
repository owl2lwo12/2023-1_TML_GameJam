using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private float speed = 0;
    private void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }

    public void MakeSetting(float setspeed)
    {
        speed = setspeed;
    }
}
