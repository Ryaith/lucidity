using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerDemonManager : MonoBehaviour
{
    public string id;
    private Vector3 axis = new Vector3(0,1,1); // axis which to rotate
    private float angle = 2; // speed of rotation 
    private int innerDemonCount = 0;

    private void Update() 
    {
        transform.RotateAround(gameObject.transform.position, axis, angle);
    }

}




