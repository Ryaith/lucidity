using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossZoneScript : MonoBehaviour
{

    public GameObject boss;
    private GeckoController_Full boss_controller;

    private void Start()
    {
        boss_controller = boss.GetComponentInChildren<GeckoController_Full>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss_controller.SetRootMotion(true);
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss_controller.SetRootMotion(false);
        }
    }
}
