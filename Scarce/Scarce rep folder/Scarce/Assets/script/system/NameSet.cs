using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameSet : MonoBehaviour
{
    string charname;

    private void Start()
    {
        GetComponent<InputField>().Select();
    }

    public void setName()
    {
        charname = GetComponent<InputField>().text;
        saveManager.plyr.ID = charname;
        Debug.Log("Data Created");
        saveManager.Save();
        SceneManager.LoadScene("menu");
    }
}
