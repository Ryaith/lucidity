using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSwitch : Switch
{
    public DarkPuzzleManager manage;
    public int index;

    // I need to keep track of the object state separately from the base class - no access to object/bool info because I can't change "Activate"'s return type
    public bool objectIsActive = true;

    public override void Activate(GameObject player)
    {
        objectIsActive = !objectIsActive;
        manage.activate(index, objectIsActive);
        base.Activate(player);
    }
}
