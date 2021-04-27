using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightmareBossManager : MonoBehaviour
{
    GameObject innerDemon;
    Turret boss;

    [SerializeField] private int numSwitches;
    bool[] hits;

    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponentInChildren<Turret>();
        innerDemon = GetComponentInChildren<InnerDemonManager>().gameObject;
        innerDemon.SetActive(false);
        hits = new bool[numSwitches];
    }

    public void hit(int switchid)
    {
        hits[switchid] = true;
        bool dead = true;
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == false)
            {
                dead = false;
            }
        }
        if (dead)
        {
            boss.enabled = false;
            innerDemon.SetActive(true);
        }
    }
}
