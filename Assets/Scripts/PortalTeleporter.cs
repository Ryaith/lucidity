using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public Transform reciever;
    public CharacterController player;

    private bool playerIsOverlapping = false;

    private void Update() 
    {
        if (playerIsOverlapping)
        {
            Vector3 portalToPlayer = player.transform.position  - transform.position;
            float dotPro = Vector3.Dot(transform.up, portalToPlayer);
            print(dotPro);
            if (dotPro < 0f)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.transform.Rotate(Vector3.up, rotationDiff);
                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.enabled =false;
                player.transform.position = reciever.position + positionOffset;
                player.enabled =true;

                playerIsOverlapping = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
