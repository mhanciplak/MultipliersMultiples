using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene8_2Story : MonoBehaviour
{
    public string[] story;
    public Text storyText;
    public string NextScene;

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

        SceneManager.LoadScene(NextScene);
    }
}
