using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getTheKey : MonoBehaviour
{
    plyrObj plyr;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if (go.GetComponent<plyrObj>().ID == saveManager.plyr.ID)
        {
            plyr = go.GetComponent<plyrObj>();
            Debug.Log("Enter, " + plyr.ID + System.Environment.NewLine + "xp: " + plyr.xp);
        }


        inGameCanvas.inGame = true;
    }

    private void Update()
    {
        if (plyr.hlth <= 0)
        {
            EndGame();
        }
    }

    public void GotKey()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public void EndGame()
    {   
        inGameCanvas.inGame = false;
        saveManager.Save();
        SceneManager.LoadScene("menu");
    }


}
