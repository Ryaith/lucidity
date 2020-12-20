using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessHallway : MonoBehaviour
{

    public GameObject player; //Track the player - The hallway must directly alter their position
    Transform playerTransform;
    CharacterController playerController;

    //Entry point tracks the smallest (or largest) coordinates of the box trigger
    //One coordinate from this vector will determine where the player is teleported to.
    Vector3 entryPoint;
    Vector3 exitPoint;
    float hallLength;
    
    Collider m_Collider;
    Vector3 forward;

    //Use these parameters to change the direction of any endless hallway - we can set them up on any cardinal direction
    public bool onX = false;
    public bool invertDirection = false;


    // Start is called before the first frame update
    void Start()
    {
        //By default, "fowards" on an endless hallway is increasing Z
        if (!onX)
        {
            forward = Vector3.forward; //(0, 0, 1)
        }
        else
        {
            forward = Vector3.right; //(1, 0, 0)
        }

        m_Collider = GetComponent<Collider>();
        playerTransform = player.GetComponent<Transform>();
        playerController = player.GetComponent<CharacterController>();

        if (!invertDirection)
        {
            entryPoint = m_Collider.bounds.min;
        }
        else
        {
            forward = forward * -1f;
            entryPoint = m_Collider.bounds.max;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit()
    {
        Vector3 playerPosition = playerTransform.position;

        UnityEngine.Debug.Log(Vector3.Angle(forward, playerTransform.forward));

        //Comparisons done in multiple steps to avoid overcomplicating the single if statement
        //I want the rest of you to be able to read this and there's no need to nest if statements

        bool exitingLimitingSide;
        Vector3 newPosition;

        if (onX)
        {
            exitingLimitingSide = !invertDirection && playerTransform.position.x > entryPoint.x || invertDirection && playerTransform.position.x < entryPoint.x;
            newPosition = new Vector3(entryPoint.x, playerTransform.position.y, playerTransform.position.z);
        }
        else
        {
            exitingLimitingSide = !invertDirection && playerTransform.position.z > entryPoint.z || invertDirection && playerTransform.position.z < entryPoint.z;
            newPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, entryPoint.z);
        }

        if (Vector3.Angle(forward, playerTransform.forward) <= 145 && exitingLimitingSide)
        {
            
            playerController.enabled = false;
            playerTransform.position = newPosition;
            playerController.enabled = true;
        }

            
        
    }
}
