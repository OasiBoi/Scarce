using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCollider : MonoBehaviour
{
    public plyrObj player;

    private void Update()
    {
        player = GetComponentInParent<plyrObj>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent("ammoObj"))
        {
            player.CollectAmmo(3);
        }
        if (other.GetComponent("hlthObj"))
        {
            player.CollectHealth(3);
        }
        if (other.GetComponent("coinObj"))
        {
            coinObj coin = other.GetComponent<coinObj>();
            int w = coin.worth;
            player.CollectCoin(w);
        }
        if (other.GetComponent("xpObj"))
        {
            xpObj xp = other.GetComponent<xpObj>();
            int p = xp.points;
            player.CollectXp(p);
        }
    }

}
