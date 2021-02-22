using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalysisPuzzleTrigger : MonoBehaviour
{
    // The puzzle is solved when the timer reaches the trigger time
    // which causes the inner demon to be fired by the turret
    // Incorrect player action resets or stops the timer.
    // We DO watch for the player's position.

    float time;
    public float triggerTime = 15;
    public float maxLookAngle = 60.0f;
    bool countdown = false;
    bool solved = false;

    public PuzzleTurret demonSource;

    public GameObject player;
    Transform playerTransform; // Tracking the transform allows us to detect motion

    Vector3 playerPosition = new Vector3(0, 0, 0);
    Vector3 forward;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        playerTransform = player.GetComponent<Transform>();
        forward = this.GetComponent<Transform>().forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown)
        {
            time += Time.deltaTime;
            if (playerTransform.position != playerPosition)
            {
                playerPosition = playerTransform.position;
                time = 0;
                UnityEngine.Debug.Log("Puzzle time reset by movement");
            }
            if (Vector3.Angle(forward, playerTransform.forward) > 60)
            {
                time = 0;
                UnityEngine.Debug.Log("Puzzle time reset by vision");
            }
            if (time >= triggerTime)
            {
                UnityEngine.Debug.Log("Turret triggered");
                demonSource.triggerAltFire();
                time = 0;
                countdown = false;

            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player" && !solved)
        {
            countdown = true;
            playerPosition = playerTransform.position;
            UnityEngine.Debug.Log("Puzzle enabled");
        }
    }

    void OnTriggerExit(Collider c)
    {
        if(c.tag == "Player")
        {
            countdown = false;
            time = 0;
            UnityEngine.Debug.Log("Puzzle disabled");
        }
    }
    
    //This is public so if the player missed the Inner Demon, it can fly by again
    public void solvePuzzle()
    {
        solved = true;
    }
}
