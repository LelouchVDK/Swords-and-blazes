using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script for button events
/// </summary>
public class Buttonhandler : MonoBehaviour
{
    

    public void Quitter()
    {
        Application.Quit();
    }
    public void SceneHandler(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
