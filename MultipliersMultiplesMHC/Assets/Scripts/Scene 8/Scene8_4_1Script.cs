using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene8_4_1Script : MonoBehaviour
{
    public InputField TotalNumber;

    public void Check()
    {
        if (TotalNumber.text == "2")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Win();

            StartCoroutine(LoadNextScene());
        }
        else
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Lose();
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Scene8_4_2");
    }
}
