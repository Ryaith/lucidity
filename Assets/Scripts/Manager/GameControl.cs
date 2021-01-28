using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance; 
    [SerializeField] private static int TC = 1; // total collectibles 
    [SerializeField] private GameObject[] Pickups = new GameObject[TC]; // List of all the collectibles in the game 
    [SerializeField] private bool[] Collected = new bool[TC]; // List of all collected items 
    [SerializeField] private int Count;
    [SerializeField] private Vector3 PlayerPosition;

    /* inits the collectibles, renames each collectible to a simple integer, which can double as its array index value later on. 
    It then stores the GameObject in the 'Pickups' array, and resets the 'Collected' state to false */
    private void Awake() 
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        var i = 0;
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Pickup"))
        {
            go.SetActive(true);
            print("Pickup " + i + " initialized");
            go.name = i.ToString();
            Pickups[i] = go;
            Collected[i] = false;
            i++;
        }
    }
    /* called from the pause menu's "Reset" and "Load Game" methods. It does the same thing as the 'Awake' initialization, 
    but omits the renaming of the game objects*/
    public void InitializeNR()
     {
         var i = 0;
         foreach (GameObject go in GameObject.FindGameObjectsWithTag("Pick-up"))
         {
             go.SetActive(true);
             print("Pickup " + i + " initialized");
             Pickups[i] = go;
             Collected[i] = false;
             i++;
         }
     } 
}
