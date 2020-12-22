using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private string displayName = "";
    [SerializeField] private string actionName;

    public void Activate()
    {
        Destroy(gameObject);
    }

    public string getActionName()
    {
        return actionName;
    }

    public string getDisplayName()
    {
        return displayName;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

