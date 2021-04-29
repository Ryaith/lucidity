using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //[SerializeField] private Transform player;
    //[SerializeField] private Transform respawnPoint;
    private GameObject player;
    private Vector3 respawnPoint;
    private void Awake()
    {
        player = GameObject.Find("Player");
        Vector3 playerPosition = player.transform.position;
        respawnPoint = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z);
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint;
        Physics.SyncTransforms();
    }
    public void setRespawn(Vector3 newDest)
    {
        respawnPoint = newDest;
    }

    public void respawn()
    {
        player.transform.position = respawnPoint;
        Physics.SyncTransforms();
    }
}
