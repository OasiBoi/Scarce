using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class plyrData
{
    public string ID;
    public int xp;
    public float hlth;
    public int moveSpd;
    public int jumpStr;
    public int ammo;
    public int money;
    public int shield;

    public plyrData(plyrObj plyr)
    {
        ID = plyr.ID;
        xp = plyr.xp;
        hlth = plyr.hlth;
        moveSpd = plyr.moveSpd;
        jumpStr = plyr.jumpStr;
        ammo = plyr.ammo;
        money = plyr.money;
        shield = plyr.shield;
    }

}
