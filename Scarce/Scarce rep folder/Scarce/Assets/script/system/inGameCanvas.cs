using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameCanvas : MonoBehaviour
{
    bool inGame = false;
    private void Update()
    {
        int i = SceneManager.GetActiveScene().buildIndex;

        if (SceneManager.GetActiveScene().name == "EnterName")
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "menu")
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "test")
        {
            inGame = true;
        }

        if (inGame)
        {
            transform.GetChild(3).gameObject.SetActive(true);

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
        }
    }
}
