using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageManager : MonoBehaviour
{
    //If we're implementing UI elements related to being hit, this class is where it should go
    bool hit;
    bool dead;
    float healTimer;
    float deathTimer;
    float damageCD;

    CharacterController playerController;
    string thisScene;
    Respawn respawnObject;
    AudioSource[] damageSounds;

    // Start is called before the first frame update
    void Start()
    {
        hit = false; //We're going off a two-hit system
        healTimer = 0f;
        deathTimer = 0f;
        playerController = GetComponent<CharacterController>();
        thisScene = SceneManager.GetActiveScene().name;
        respawnObject = GameObject.Find("RespawnManager").GetComponent<Respawn>();
        damageSounds = GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //Handles health regeneration
        if (healTimer > 0)
        {
            healTimer -= Time.deltaTime;
            if (healTimer <= 0)
            {
                hit = false;
                UnityEngine.Debug.Log("Healed damage");
            }
        }
        if (dead)
        {
            deathTimer += Time.deltaTime;
            if (deathTimer >= 5f)
            {
                //SceneManager.LoadScene(thisScene);
                playerController.enabled = true;
                hit = false;
                dead = false;
                respawnObject.respawn();
                deathTimer = 0;
            }
        }

        if (damageCD > 0)
        {
            damageCD -= Time.deltaTime;
        }
    }

    public void damage()
    {
        UnityEngine.Debug.Log("Took damage");
        //Can't take damage if you've just been hit
        if (damageCD <= 0)
        {
            if (hit)
            {
                playerController.enabled = false; //Probably a more elegant solution to disable control while dead
                if (!dead)
                {
                    damageSounds[1].Play();
                }
                dead = true;
                
            }
            else
            {
                hit = true;
                healTimer = 10f;
                damageSounds[0].Play();
            }
            damageCD = 2f;
        }

    }

}
