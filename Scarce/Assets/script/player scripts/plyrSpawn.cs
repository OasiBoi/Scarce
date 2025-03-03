﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plyrSpawn : MonoBehaviour
{
    plyrObj plyr;

    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if (go.GetComponent<plyrObj>().ID == saveManager.plyr.ID)
        {
            plyr = go.GetComponent<plyrObj>();
            plyr.stmn = 100;
        }

        StartCoroutine(SpawnPlayer());
    }

    IEnumerator SpawnPlayer()
    {
        yield return new WaitForSeconds(5);
        plyr.transform.position = this.transform.position;
        Instantiate(plyr.plyrbod, plyr.transform);

    }

    private void OnDestroy()
    {
        saveManager.plyr.DestroyChild();
    }

}
