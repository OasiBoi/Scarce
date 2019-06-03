using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveManager : MonoBehaviour
{

    public GameObject plyrprefab;
    GameObject playerObj;
    public static plyrObj plyr;
    public static plyrData data;

    private void Start()
    {
        if (playerObj == null)
        {
            playerObj = Instantiate(plyrprefab);
            plyr = playerObj.GetComponent<plyrObj>();
            data = new plyrData(plyr);
            Debug.Log("player created");
        }


        if (saveSystem.FileCheck() == false && SceneManager.GetActiveScene().name != "EnterName")
        {
            NewData();
        }
        else
        {
            SceneManager.LoadScene("menu");
            Load();
        }
    }

    public static void Save()
    {
        saveSystem.SaveData(plyr);
    }

    public void Load()
    {
        data = saveSystem.LoadData();

        plyr.ID         = data.ID;
        plyr.xp         = data.xp;
        plyr.hlth       = data.hlth;
        plyr.moveSpd    = data.moveSpd;
        plyr.moveSpd    = data.moveSpd;
        plyr.jumpStr    = data.jumpStr;
        plyr.ammo       = data.ammo;
        plyr.money      = data.money;
        plyr.shield     = data.shield;


    }

    public void NewData()
    {
        plyr.ammo = 5;
        plyr.hlth = 100;
        plyr.xp = 0;
        plyr.money = 1000;
        plyr.moveSpd = 1;
        plyr.shield = 3;
        SceneManager.LoadScene("EnterName");
    }
}
