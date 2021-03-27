using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockInteract : MonoBehaviour, IInteractable
{

    string displayName = "Clock";
    string actionName = "Adjust";

    public GameObject ghostWall;
    public int ghostTime = 3;
    Clock clockScript;
    int hours;

    public string getDisplayName()
    {
        return displayName;
    }

    public string getActionName()
    {
        return actionName;
    }

    // Start is called before the first frame update
    void Start()
    {
        clockScript = GetComponentInChildren<Clock>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hours != clockScript.hour)
        {
            hours = (hours + 1) % 12;
            updateWall();
        }
    }

    public void Activate(GameObject player)
    {
        hours = (hours + 1) % 12;
        clockScript.hour = hours;
        updateWall();
    }

    void updateWall()
    {
        if (hours == ghostTime)
        {
            ghostWall.layer = 11;
        }
        else
        {
            ghostWall.layer = 0;
        }
    }

}
