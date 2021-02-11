using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionManager : MonoBehaviour
{
    public GameObject holdDest;

    [SerializeField]
    private TextMeshProUGUI messageBox;

    public GameObject getHoldingDestObject()
    {
        return holdDest;
    }


    public void PrintMessageForSeconds(string message, float time)
    {
        messageBox.enabled = true;
        messageBox.text = message;
        StartCoroutine(messageboxForSeconds(time));
    }

    IEnumerator messageboxForSeconds(float time)
    {
        yield return new WaitForSeconds(time);
        messageBox.enabled = false;
    }

}
