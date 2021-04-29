using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractCast : MonoBehaviour
{

    private GameObject selectedObj;
    [SerializeField]
    private LayerMask interactionLayer;
    [SerializeField]
    private int maxInteractionDist = 5;

    [SerializeField]
    private Image crosshair;

    [SerializeField]
    private TextMeshProUGUI objName;
    [SerializeField]
    private TextMeshProUGUI actionName;
    
    public GameObject playerParent;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, maxInteractionDist, interactionLayer.value))
        {
            //Rigidbodies work weirdly with raycasts. The collider size needs to icnrease for rigidbodies to work.
            //It's why I decided to use 2 different colliders, one for collisions and one for raycast detection
            //to disable interactions for any purpose you can temporarily disable the raycast-detection collider
            selectedObj = hit.collider.gameObject.transform.parent.gameObject;
            IInteractable interactableObj = selectedObj.GetComponent<IInteractable>();
            
            selectObject(interactableObj.getDisplayName(), interactableObj.getActionName());
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactableObj.Activate(playerParent);
            }
        }
        else
        {
            deselectObject();
            selectedObj = null;
        }
    }


    private void selectObject(string displayName, string action)
    {
        crosshair.color = Color.green;
        objName.text = displayName;
        actionName.text = action;
    }


    private void deselectObject()
    {
        crosshair.color = Color.white;
        objName.text = string.Empty;
        actionName.text = string.Empty;
    }
}
