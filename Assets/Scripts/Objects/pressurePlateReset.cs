using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlateReset : MonoBehaviour{
    [SerializeField] List<PressurePlate> pressurePlateList;
    [SerializeField] PressurePlateManager myManager;

				private void OnTriggerEnter(Collider other) {
								
								for (int i = 0; i < pressurePlateList.Count; i++) {
												pressurePlateList[i].setPlateInactive();
								}
								myManager.resetPlates();
				}
				public void goal() {
								for (int i = 0; i < pressurePlateList.Count; i++) {
												pressurePlateList[i].goal();
								}
				}

}
