using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour{
    [SerializeField] private PressurePlateManager myManager;
				[SerializeField] private GameObject self;
				[SerializeField] private int activeTime;
				
				private bool activated = false;
				public Color red = new Color(100, 0, 0);
				public Color blue = new Color(0, 0, 100);
				public Color gold = new Color(241, 107, 47);
				private Material myMaterial;
				private int myId = 0;
				private bool win = false;
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
				public void goal() {
								win = true;
								setPlateActive();
								myMaterial.color = gold;
				}
				public void setPlateActive() {
								activated = true;
								myManager.setPlateActive();
								myMaterial.color = red;
								StartCoroutine(myTimer(myId));
				}
				public void setPlateInactive() {
								if (!win) {
												activated = false;
												myManager.setPlateInactive();
												myMaterial.color = blue;
								}
								
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
