﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryScriptGeneric : MonoBehaviour
{
    public string[] story;
    public Text storyText;
    public int timeBtwStories;
    public string WinText, LoseText;
    public bool isAutoNextScene;
    public string NextSceneName;

    void Start()
    {
        StartCoroutine(StartStory());
    }

    IEnumerator StartStory()
    {
        foreach (var item in story)
        {
            storyText.text = item;
            yield return new WaitForSeconds(timeBtwStories);
        }

        if (isAutoNextScene)
        {
            yield return new WaitForSeconds(3);

            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(NextSceneName);
    }

    public void SetText(string text)
    {
        storyText.text = text;
    }

    public void Win()
    {
        storyText.text = WinText;
    }

    public void Lose()
    {
        storyText.text = LoseText;
    }

}
