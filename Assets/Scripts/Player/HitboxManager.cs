using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxManager : MonoBehaviour
{
    GameObject player;
    Transform myself;
    DamageManager damager;
    bool initialized;

    // Start is called before the first frame update
    void Start()
    {
        myself = GetComponent<Transform>();
        player = transform.root.gameObject;
        initialized = false;
    }

    public void damage()
    {
        if (!initialized)
        {
            damager = player.GetComponent<DamageManager>();
            initialized = true;
        }
        damager.damage();
    }
}
