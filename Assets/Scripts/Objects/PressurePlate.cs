using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour{
    [SerializeField] private PressurePlateManager myManager;
				[SerializeField] private GameObject self;
				[SerializeField] private int activeTime;
				
				private bool activated = false;
				private Color red = new Color(100, 0, 0);
				private Color blue = new Color(0, 0, 100);
				private Material myMaterial;
				private int myId = 0;
				private void Awake() {
								myMaterial = self.GetComponent<Renderer>().material;
								myMaterial.color = blue;
				}
				IEnumerator myTimer(int id) {
								
								yield return new WaitForSeconds(activeTime);
								if (activated && id==myId) {
												setPlateInactive();
								}

				}
				public void setPlateActive() {
								activated = true;
								myManager.setPlateActive();
								myMaterial.color = red;
								StartCoroutine(myTimer(myId));
				}
				public void setPlateInactive() {
								activated = false;
								myManager.setPlateInactive();
								myMaterial.color = blue;
				}
				private void OnTriggerEnter(Collider other) {
								myId++;
								if (activated) {
												setPlateInactive();
								}
								else {
												setPlateActive();
												
								}
				}
}
