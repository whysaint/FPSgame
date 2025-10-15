using System;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 3.0f;
    public float maxZ = 16.0f;
    public float minZ = -16.0f;

    private int derection = 1;

    private void Update()
    {
        transform.Translate(0, 0 , derection * speed * Time.deltaTime);

        bool bounced = false;
        if (transform.position.z > maxZ || transform.position.z < minZ)
        {
            derection = -derection;
            bounced = true;
        }

        if (bounced)
        {
            transform.Translate(0,0, derection * speed * Time.deltaTime);
        }
    }
}
