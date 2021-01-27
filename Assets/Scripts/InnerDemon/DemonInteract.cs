using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemonInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;

    public void Activate(){
        Destroy(gameObject);
        SceneManager.LoadScene(0);
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

