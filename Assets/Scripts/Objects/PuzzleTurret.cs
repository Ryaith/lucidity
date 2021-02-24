using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTurret : Turret
{
    //THIS MUST BE SET TO "REUSABLE" - CHECK THE PROJECTILE ASSET IF A CRASH OCCURS
    public GameObject reward;

    public void triggerAltFire()
    {
        bulletCode = reward.GetComponent<GhostProjectile>();
    }
}
