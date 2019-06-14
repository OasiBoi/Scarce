using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class defButton : MonoBehaviour
{
    plyrData data;
    private void Start()
    {
        transform.parent.GetChild(0).GetComponent<Button>().Select();
    }

    public static void ToSceneStat(string i)
    {
        saveManager.Save();
        SceneManager.LoadScene(i);
    }

    public void ToScenewSave(string i)
    {
        saveManager.Save();
        SceneManager.LoadScene(i);
    }

    public void ToScene(string i)
    {
        SceneManager.LoadScene(i);
    }

    public void Quit()
    {
        saveManager.Save();
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

}
