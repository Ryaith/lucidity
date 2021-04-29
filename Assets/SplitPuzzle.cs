using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitPuzzle : MonoBehaviour
{
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject demon;
    public bool solved = false;

    private void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "Player" && sprite1.activeSelf == true)
        {
            if (collision.gameObject.transform.rotation.y > -0.90 && collision.gameObject.transform.rotation.y < -0.60)
                StartCoroutine(ExampleCoroutine());
        }
    }

    public IEnumerator ExampleCoroutine()
    {
        Debug.Log("TEST2");
        yield return new WaitForSeconds(1);
        if (sprite1.activeSelf == true)
        {
            sprite1.SetActive(false);
            sprite2.SetActive(false);
            demon.SetActive(true);
        }    
    }
}
