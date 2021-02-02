using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject destinationPoint;
    void OnTriggerEnter(Collider col)
    {
        if (destinationPoint)
        {
            GameObject target = col.gameObject;
            Teleport(target);
        }
    }
    


    private void Teleport(GameObject target)
    {
        target.SetActive(false);
        target.transform.position = destinationPoint.transform.position;
        target.SetActive(true);
    }
}
