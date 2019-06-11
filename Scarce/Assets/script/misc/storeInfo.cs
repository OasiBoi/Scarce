using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeInfo : MonoBehaviour
{

    plyrObj plyr;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if (go.GetComponent<plyrObj>().ID == saveManager.plyr.ID)
        {
            plyr = go.GetComponent<plyrObj>();
            Debug.Log("Enter, " + plyr.ID + System.Environment.NewLine + "xp: " + plyr.xp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).GetComponent<Text>().text = "$: " + plyr.money.ToString();

        store s = GetComponent<store>();
        if (s.isSelected)
        {
            transform.GetChild(2).GetComponent<Text>().text = s.amnt.ToString();
            transform.GetChild(3).GetComponent<Text>().text = "$: -" + s.prc.ToString();
        }

    }
}
