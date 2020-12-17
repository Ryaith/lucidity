using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInteraction : MonoBehaviour, IInteractable
{

    public string displayName;

    public string actionName;


    public void Activate()
    {
        Debug.Log("Activated");
        gameObject.SetActive(false);
    }

    public string getDisplayName()
    {
        return displayName;
    }

    public string getActionName()
    {
        return actionName;
    }
}
