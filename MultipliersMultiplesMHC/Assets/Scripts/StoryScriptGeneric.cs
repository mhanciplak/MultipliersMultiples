using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScriptGeneric : MonoBehaviour
{
    public string[] story;
    public Text storyText;
    public int timeBtwStories;
    public string WinText, LoseText;

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
