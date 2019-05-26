using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene8_5_1Script : MonoBehaviour
{
    public InputField TotalInput;
    public Animator CarAnimator;

    void Start()
    {
        CarAnimator.enabled = false;
    }

    public void Check()
    {
        if (TotalInput.text == "2")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Win();

            CarAnimator.Play("CarAnimation");
            CarAnimator.enabled = true;

            StartCoroutine(LoadNext());
        }
        else
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Lose();
    }

    IEnumerator LoadNext()
    {
        yield return new WaitForSeconds(8);

        SceneManager.LoadScene("Scene8_5_2");
    }
}
