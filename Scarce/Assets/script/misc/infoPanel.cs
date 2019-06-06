using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoPanel : MonoBehaviour
{
    void Update()
    {
        plyrObj plyr = saveManager.plyr;

        transform.GetChild(0).GetComponent<Text>().text =  "sup, " + plyr.ID;
        transform.GetChild(1).GetComponent<Text>().text = "xp: " + plyr.xp.ToString();
        transform.GetChild(2).GetComponent<Text>().text = "$:"  + plyr.money.ToString();
        transform.GetChild(3).GetComponent<Text>().text = "hp: " + plyr.hlth.ToString();
        transform.GetChild(4).GetComponent<Text>().text = "ammo: " + plyr.ammo.ToString();

    }
}
