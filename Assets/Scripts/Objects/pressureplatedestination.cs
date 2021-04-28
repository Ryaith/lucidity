using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplatedestination : MonoBehaviour{
    [SerializeField] private PressurePlateManager myManager;
    [SerializeField] private pressurePlateReset myReset;

				private void OnTriggerEnter(Collider other) {
								myManager.goal();
								myReset.goal();
				}
}
