using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonhandler : MonoBehaviour
{
    public void SceneHandler(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
