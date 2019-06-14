using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameCanvas : MonoBehaviour
{
    public static bool inGame = false;
    private void Update()
    {
        int i = SceneManager.GetActiveScene().buildIndex;


        //load name input if in name input screen
        if (SceneManager.GetActiveScene().name == "EnterName")
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        //load menu if in start screen
        if (SceneManager.GetActiveScene().name == "menu")
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        //load store screen if in store scene
        if (SceneManager.GetActiveScene().name == "store")
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(5).gameObject.SetActive(false);
        }

        //show game select if in game select scene
        if (SceneManager.GetActiveScene().name == "GameModes")
        {
            transform.GetChild(6).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(6).gameObject.SetActive(false);
        }

        //show pause screen if in game
        if (inGame)
        {
            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(4).gameObject.SetActive(true);

            if (Input.GetButtonDown("Submit"))
            {
                if (transform.GetChild(1).gameObject.activeSelf == false) {                     
                    transform.GetChild(1).gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    transform.GetChild(1).gameObject.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
        else
        {
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(4).gameObject.SetActive(false);
        }
    }
}
