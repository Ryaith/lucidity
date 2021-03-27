using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfTruth : MonoBehaviour{
    [SerializeField] private EyeOfTruth me;
    [SerializeField] private List<GameObject> invisibleObject;
    public void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            me.gameObject.SetActive(false);
												for (int i=0;i<invisibleObject.Count;i++) {
                invisibleObject[i].GetComponent<MeshRenderer>().enabled = true;
            }
            
        }
    }
}
