using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Respawn respawn;
    [SerializeField] private GameObject destination;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            respawn.setRespawn(destination.transform.position);
        }
    }
}
