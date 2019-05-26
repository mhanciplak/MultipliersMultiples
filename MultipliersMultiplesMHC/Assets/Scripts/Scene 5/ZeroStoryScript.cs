using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZeroStoryScript : MonoBehaviour
{
    public Text storyText;
    public string[] story;
    public float timeBetweenStory;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(PlayStory());
    }

    IEnumerator PlayStory()
    {
        foreach (var item in story)
        {
            storyText.text = item;
            yield return new WaitForSeconds(timeBetweenStory);
        }
    }
}
