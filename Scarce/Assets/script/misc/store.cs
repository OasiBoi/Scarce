using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class store : MonoBehaviour
{
    plyrObj plyr;
    public int amnt;
    public int prc;
    public bool isSelected;
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

    public void OnSelect(BaseEventData eventData)
    {
        isSelected = true;
    }

    public void AddAmmo()
    {
        if (plyr.money - prc >= 0 )
        {
            plyr.CollectAmmo(amnt);
        }
    }
    public void AddHealth()
    {
        if (plyr.money - prc >= 0)
        {
            plyr.CollectHealth(amnt);
        }
    }
    public void SubCoin()
    {
        if (plyr.money - prc >= 0)
        {
            plyr.CollectCoin(-prc);
        }
        else
        {
            Debug.Log("not enough doh");
        }
    }
}