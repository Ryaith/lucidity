using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour{
				public int destination;
				public GameObject helpInfo;
				int helpActive = 0;
				public void Exit() {
								Application.Quit();
				}
				public void Play() {
								SceneManager.LoadScene(destination);
				}
				public void Help() {
								if (helpActive==0) {
												helpInfo.SetActive(true);
												helpActive = 1;
								}
								else {
												helpInfo.SetActive(false);
												helpActive = 0;
								}
								
				}
}
