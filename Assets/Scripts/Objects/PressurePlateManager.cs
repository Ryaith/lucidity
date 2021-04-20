using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateManager : MonoBehaviour{
    [SerializeField] private int numPlates;
    [SerializeField] private GameObject blockade;
    private int platesActive;

    public void setPlateActive() {
        platesActive++;
        if (platesActive == numPlates) {
            blockade.SetActive(false);
								}
				}
    public void setPlateInactive() {
        platesActive--;
				}
}
