using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSwitch : MonoBehaviour, IInteractable
{
    /*
     * A switch that can activate one or more "Activateable" objects at a time
     * 
     */
   


     //should be GameObjects containing IInteractable component that are not on the Interaction Layer
    //You don't want objects controlled by the switch to be able to be manually interacted with

    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;
    public List<GameObject> linkedObjects;
    public string getDisplayName()
    {
        return displayName;
    }

    public string getActionName()
    {
        return actionName;
    }

    public void Activate()
    {
        foreach(GameObject obj in linkedObjects)
        {
            IInteractable interactionComp = obj.GetComponent<IInteractable>();
            interactionComp.Activate();
        }
    }

}
