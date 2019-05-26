using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour {

	public Text storyText;
	public string[] story;
    private int i = 0;

    private bool coroutineEnded;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartStory());
	}

    IEnumerator StartStory()
    {
        while (i < 6)
        {
            storyText.text = story[i++];
            yield return new WaitForSeconds(1);
        }

        coroutineEnded = true;
    }

	public void NextStory() {
        if (coroutineEnded)
        {
            if (i < story.Length)
            {
                storyText.text = story[i++];
            }
            else
            {
                // SceneManager.LoadScene("Scene3");
            }
        }
    }
}
