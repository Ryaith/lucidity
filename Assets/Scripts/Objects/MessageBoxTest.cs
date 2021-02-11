using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBoxTest : MonoBehaviour, IInteractable
{
    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;
    [SerializeField] private float displayTime;
    [SerializeField] private string message;

    public void Activate(GameObject player)
    {
        player.GetComponent<InteractionManager>().PrintMessageForSeconds(message, displayTime);

    }

    public string getActionName()
    {
        return actionName;
    }

    public string getDisplayName()
    {
        return displayName;
    }
}
