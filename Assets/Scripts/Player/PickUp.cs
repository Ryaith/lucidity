using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour, IInteractable
{   
    [SerializeField] private Transform theDest;
    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;
    private bool isInAir = false; 

    public void Activate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isInAir = true;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Dest").transform;
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
