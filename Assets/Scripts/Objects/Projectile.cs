using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float maxSpeed = 0.15f;
    public float maxRange = 30f;
    protected float bulletSpeed;

    protected Vector3 origin;
    protected Vector3 distance;
    protected Rigidbody bullet;


    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = 0f;
        bullet = GetComponent<Rigidbody>();
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        bullet.MovePosition(bullet.position + bullet.transform.forward * bulletSpeed);
        distance = bullet.position - origin;
        UnityEngine.Debug.DrawRay(origin, distance, Color.yellow);

        //Defines the max range of the bullet
        if (distance.magnitude > maxRange)
        {
            Destroy(gameObject);
        }
    }

    public void fire(Vector3 originPoint)
    {
        //Fires the projectile forwards from the given position
        //Make sure the projectile is rotated correctly
        //We can implement another fire method that rotates the projectile if needed in the future
        origin = originPoint;
        bulletSpeed = maxSpeed;
        bullet.transform.position = new Vector3(origin.x, origin.y, origin.z);
    }

    //Hitboxes are triggers, and projectiles should be on the DAMAGE layer
    //So they cannot collide with any non-hitbox
    void OnTriggerEnter(Collider other)
    {
        HitboxManager hitbox = other.gameObject.GetComponent<HitboxManager>();
        hitbox.damage();
    }

}
