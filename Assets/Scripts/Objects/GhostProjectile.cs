using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostProjectile : Projectile
{
    public float vertSpeed;
    float activeVertSpeed = 0;
    public bool reusable = false;
    double x = 0;
    bool fired = false;
    //Up = 1, down = -1

    // Update is called once per frame
    void Update()
    {
        bullet.MovePosition(bullet.position + bullet.transform.forward * bulletSpeed + Vector3.up * (float)Math.Cos(x) * activeVertSpeed);
        x += Time.deltaTime / 2;

        //No chance of integer overflow here BAY BEE
        if (x > 1000)
        {
            x -= 1000;
        }
        distance = bullet.position - origin;

        //Defines the max range of the bullet
        if (distance.magnitude > maxRange)
        {
            if (!reusable)
            {
                Destroy(gameObject);
            }
            else
            {
                // Make this projectile inactive again
                bulletSpeed = 0;
                bullet.transform.position = new Vector3(origin.x, -10, origin.z);
            }
        }
    }

    public void fire(Vector3 originPoint)
    {
        x = 0;
        activeVertSpeed = vertSpeed;
        base.fire(originPoint);
    }
}
