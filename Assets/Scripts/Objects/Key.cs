using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IInteractable {

    [SerializeField] private string displayName = "Key";
    [SerializeField] private string actionName;
    public DoorManager myManager;
    public string getDisplayName() {
        return displayName;
    }

    public string getActionName() {
        return actionName;
    }

    public void Activate(GameObject Player) {
        myManager.increment();
        this.gameObject.SetActive(false);
    }
}
