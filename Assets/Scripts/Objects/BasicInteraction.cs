using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInteraction : MonoBehaviour, IInteractable
{

    public string displayName;

    public string actionName;

    [SerializeField] private bool state = true;

    public void Activate()
    {
        Debug.Log("Activated");
        ToggleState();
        gameObject.SetActive(state);
    }

    public string getDisplayName()
    {
        return displayName;
    }

    public string getActionName()
    {
        return actionName;
    }

    private void ToggleState()
    {
        state = state ? false : true;
    }
}
