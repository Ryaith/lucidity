using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightmareBossSwitch : Switch
{
    public int switchid;
    NightmareBossManager boss;
    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponentInParent<NightmareBossManager>();
    }

    public override void Activate(GameObject player)
    {
        boss.hit(switchid);
    }
}
