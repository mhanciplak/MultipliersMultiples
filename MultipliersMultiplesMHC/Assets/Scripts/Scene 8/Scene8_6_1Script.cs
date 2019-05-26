using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene8_6_1Script : MonoBehaviour
{
    public Animator PencilsAnimator;
    public InputField GroupNumber;

    void Start()
    {
        PencilsAnimator.enabled = false;
    }

    public void Check()
    {
        if (GroupNumber.text == "4")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>().Win();

            PencilsAnimator.Play("PencilsAnimation");
            PencilsAnimator.enabled = true;

            StartCoroutine(LoadNext());
        }
        else
            this.gameObject.GetComponent<StoryScriptGeneric>().Lose();
    }

    IEnumerator LoadNext()
    {
        yield return new WaitForSeconds(8);

        SceneManager.LoadScene("Scene8_6_2");
    }
}
