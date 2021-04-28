using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    //Turret is intended to be attached to bosses, specifically the Nightmare Boss
    public float shotDelay;
    public float sequenceDelay;
    public bool enabled;
    public int shotCount;
    public GameObject projectile;

    int sequenceCount;
    float timer;
    bool cooldown;

    Transform m_transform;

    GameObject newProjectile;
    protected Projectile bulletCode;


    // Start is called before the first frame update
    void Start()
    {
        sequenceCount = 0;
        timer = 0f;
        cooldown = false;
        m_transform = GetComponent<Transform>();

        //Projectiles must be prepared in advance to allow for the Projectile script's Start() method to run
        newProjectile = Instantiate(projectile);
        bulletCode = newProjectile.GetComponent<Projectile>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            timer += Time.deltaTime;
            if (timer >= shotDelay && !cooldown)
            {
                timer -= shotDelay;

                //cringe but I couldn't get the child's fire method to trigger without this
                if (bulletCode is GhostProjectile)
                {
                    ((GhostProjectile) bulletCode).fire(m_transform.position);
                }
                else
                {
                    bulletCode.fire(m_transform.position);
                }
                

                newProjectile = Instantiate(projectile, projectile.transform.position, projectile.transform.rotation);
                bulletCode = newProjectile.GetComponent<Projectile>();
                sequenceCount += 1;
                if (sequenceCount == shotCount)
                {
                    cooldown = true;
                }
            }
            else if (cooldown && timer >= sequenceDelay)
            {
                timer -= sequenceDelay;
                timer += shotDelay; //Force instant fire
                sequenceCount = 0;
                cooldown = false;
            }
        }

    }

    public void enable(bool state)
    {
        enabled = state;
        sequenceCount = 0;
        timer = 0f;
        cooldown = false;
    }
}
