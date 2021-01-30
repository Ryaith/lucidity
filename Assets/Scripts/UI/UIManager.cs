using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI MessageBox;

    [SerializeField]
    private float messageDisplayTime = 5f;

    public void DisplayMessage(string message)
    {
        StartCoroutine(DisplayMessageForTime(message, messageDisplayTime));
    }

    public void DisplayMessage(string message, float time)
    {
        StartCoroutine(DisplayMessageForTime(message, time));
    }




    IEnumerator DisplayMessageForTime(string message, float time)
    {
        MessageBox.text = message;
        MessageBox.enabled = true;
        yield return new WaitForSeconds(time);
        MessageBox.enabled = false;
        
    }


}
