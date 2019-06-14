using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getTheKey : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

<<<<<<< Updated upstream
=======
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
        if (plyr.hlth <= 0 && plyr.stmn <= 0)
        {
            EndGame();
        }
>>>>>>> Stashed changes
    }

    public void GotKey()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("menu");
    }


}
