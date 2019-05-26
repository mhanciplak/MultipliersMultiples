using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string PrevScene, NextScene;

    public void LoadPrevious()
    {
        LoadScene(PrevScene);
    }

    public void LoadNext()
    {
        LoadScene(NextScene);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
