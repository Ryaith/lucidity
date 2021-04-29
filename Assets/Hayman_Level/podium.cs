using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podium : MonoBehaviour, IInteractable {
    [SerializeField] private string displayName = "Key";
    [SerializeField] private string actionName;
    public DoorManager myManager;
				
				public string getDisplayName() {
        displayName = "You have " + myManager.remaining() + " keys remaining";
        return displayName;
    }

    public string getActionName() {
        return actionName;
    }

    public void Activate(GameObject Player) {
        
    }
}
