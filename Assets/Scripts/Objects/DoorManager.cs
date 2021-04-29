using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour{
    [SerializeField] private List<int> keysNeeded;
    [SerializeField] private List<GameObject> barriers;
    private int currentBarrier=0;
    private int numKeys= 0;
    public void increment() {
        numKeys += 1;
        if(currentBarrier<keysNeeded.Count){
								    if (keysNeeded[currentBarrier] <= numKeys) {
                barriers[currentBarrier].GetComponent<Animator>().SetTrigger("openDoor");
                currentBarrier += 1;
								    }
        }
				}
    public int remaining() {
        if (keysNeeded[currentBarrier] <= 0)
        {
          return 0;
        }
        else
        {
          return keysNeeded[currentBarrier] - numKeys;
        }
        
				}
}
