using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTeleporter : MonoBehaviour{
				[SerializeField] private GameObject destination;

				private void OnTriggerEnter(Collider other) {
								if (other.tag == "Player") {
												other.transform.position = destination.transform.position;
												Physics.SyncTransforms();
								}
				}
}
