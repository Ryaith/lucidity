using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour, IInteractable
{
    public string displayName;

    public string actionName;
    public string getDisplayName()
    {
        return displayName;
    }

    public string getActionName()
    {
        return actionName;
    }

    [SerializeField] private GameObject activationObject;


    public void Activate(GameObject player)
    {
        bool isActive = activationObject.activeSelf;
        if (isActive)
        {
            activationObject.SetActive(false);
        }
        else
        {
            activationObject.SetActive(true);
        }
    }
}
