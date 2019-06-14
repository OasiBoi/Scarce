using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class igui : MonoBehaviour
{
    public bool Right;
    plyrObj plyr;

    public float stmn;
    public float hlth;

    public Slider s0;
    public Slider s1;

    // Update is called once per frame
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if (go.GetComponent<plyrObj>().ID == saveManager.plyr.ID)
        {
            plyr = go.GetComponent<plyrObj>();
            Debug.Log("Enter, " + plyr.ID + System.Environment.NewLine + "xp: " + plyr.xp);
            s0.maxValue = plyr.stmn;
            s1.maxValue = plyr.hlth;
        }

    }

    private void Update()
    {
        if (Right)
        {

            s0.value = plyr.stmn;
            s1.value = plyr.hlth;
        }
        if (!Right)
        {
            transform.GetChild(0).GetComponent<Text>().text = "money: " + plyr.money.ToString();
            transform.GetChild(1).GetComponent<Text>().text = "ammo: " + plyr.ammo.ToString();
        }
    }
}
