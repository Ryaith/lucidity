using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{

    //Name of the Object
    string getDisplayName();

    //Name of the action to be performed (currently not used)
    string getActionName();

     void Activate();

}
