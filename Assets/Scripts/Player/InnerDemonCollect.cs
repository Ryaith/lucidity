using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerDemonCollect : MonoBehaviour
{
    int goID;


    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("InnerDemon"))
        {
            other.gameObject.SetActive(false);
            goID = int.Parse(other.gameObject.name);
            GameControl.Instance.Collected[goID] = true;
            print("Got Pickup" + goID);
            GameControl.Instance.Count = GameControl.Instance.Count + 1;
        }
    }
}
