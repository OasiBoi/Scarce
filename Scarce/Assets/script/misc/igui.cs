using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class igui : MonoBehaviour
{
    public bool Right;
    plyrObj plyr;


    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if (go.GetComponent<plyrObj>().ID == saveManager.plyr.ID)
        {
            plyr = go.GetComponent<plyrObj>();
            Debug.Log("Enter, " + plyr.ID);
        }

        float stmn = Mathf.Clamp01(plyr.stmn);
        float hlth = Mathf.Clamp01(plyr.hlth);

        if (Right)
        {
            transform.GetChild(0).GetComponent<Slider>().value = plyr.stmn;
            transform.GetChild(1).GetComponent<Slider>().value = plyr.hlth;
        }
        if (!Right)
        {
            transform.GetChild(0).GetComponent<Text>().text = "ammo: " + plyr.money.ToString();
            transform.GetChild(1).GetComponent<Text>().text = "xp: " + plyr.ammo.ToString();
        }
    }
}
