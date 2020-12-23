using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossZoneScript : MonoBehaviour
{

    public GameObject boss;
    private GeckoController_Full boss_controller;

    //Grab the boss_controller script from the boss at start
    private void Start()
    {
        boss_controller = boss.GetComponentInChildren<GeckoController_Full>();
    }

    //Set the boss controller to movement when player enter the boss zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss_controller.SetRootMotion(true);
        }
    }

    //Set the boss controller to no movement when player leaves the boss zone
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss_controller.SetRootMotion(false);
        }
    }
}
