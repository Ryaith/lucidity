using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalysisProjectile : Projectile
{
    void OnTriggerEnter(Collider other)
    {
        HitboxManager hitbox = other.gameObject.GetComponent<HitboxManager>();
        //Hitboxes are only attached to players - the root wil always have a character controller
        CharacterController speedCheck = other.transform.root.gameObject.GetComponent<CharacterController>();
        
        //UnityEngine.Debug.Log(speedCheck.velocity);
        if (speedCheck.velocity != Vector3.zero)
        {
            hitbox.damage();
        }
        
    }
}
