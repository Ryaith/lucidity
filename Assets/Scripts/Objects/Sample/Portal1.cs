using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1 : MonoBehaviour, IInteractable {
    public int destination;
    public string displayName;

    public string actionName;
    public string getDisplayName() {
        return displayName;
    }

    public string getActionName() {
        return actionName;
    }

    public void Activate(GameObject player) {
        SceneManager.LoadScene(destination);
    }
}
