using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScriptGeneric : MonoBehaviour
{
    public string[] story;
    public Text storyText;

    void Start()
    {
        StartCoroutine(StartStory());
    }

    IEnumerator StartStory()
    {
        foreach (var item in story)
        {
            storyText.text = item;
            yield return new WaitForSeconds(3);
        }
    }

    public void SetText(string text)
    {
        storyText.text = text;
    }

}
