using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateManager : MonoBehaviour{
    [SerializeField] private int numPlates;
    [SerializeField] private GameObject blockade;
 
    private int platesActive;
    private bool win=false;

    public void setPlateActive() {
        platesActive++;
        if (platesActive == numPlates) {
            blockade.SetActive(false);
								}
				}
    public void setPlateInactive() {
        platesActive--;
        if (!win) {
            blockade.SetActive(true);
        }
        
				}
    public void resetPlates() {
        platesActive = 0;
				}
    public void goal() {
        win = true;
        blockade.SetActive(false);
        
				}
}
