using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfTruth : MonoBehaviour, IInteractable {
    
    [SerializeField] private List<GameObject> invisibleObject;
    [SerializeField] private string displayName = "Eye of Truth";
    [SerializeField] private string actionName;
    
    public string getDisplayName() {
        return displayName;
    }

    public string getActionName() {
        return actionName;
    }

    public void Activate(GameObject Player) {
        this.gameObject.SetActive(false);
        for (int i = 0; i < invisibleObject.Count; i++) {
            invisibleObject[i].GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
