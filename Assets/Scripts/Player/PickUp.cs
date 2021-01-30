using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour, IInteractable
{   
    [SerializeField] private Transform theDest;
    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;
    private bool isInAir = false; 

    public void Activate(GameObject player)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject dest = player.GetComponent<InteractionManager>().getHoldingDestObject();
            isInAir = true;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = dest.transform.position;
            this.transform.parent = dest.transform;
        } 
    }

    public string getActionName()
    {
        return actionName;
    }

    public string getDisplayName()
    {
        return displayName;
    }

    private void Update() 
    {
        if (Input.GetKeyUp(KeyCode.E) && isInAir)
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }
        
    }
    
}
