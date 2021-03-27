using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DarkPuzzleManager : MonoBehaviour
{

    //We're looking for all lights to be inactive

    bool[] switches;
    bool enabled = true;
    public int numSwitches;
    public GameObject innerDemon;

    void Start()
    {
        switches = new bool[numSwitches];
        for (int i = 0; i < numSwitches; i++)
        {
            switches[i] = true;
        }
    }

    public void activate(int index, bool value)
    {
        switches[index] = value;
        if (!switches[0] && !switches[1] && !switches[2] && !switches[3] && enabled)
        {
            innerDemon.SetActive(true);
            enabled = false;
        }
    }

}
