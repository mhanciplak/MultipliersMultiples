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
        CarAnimator.Play("CarsIdle");
    }

    public void Check()
    {
        if (TotalInput.text == "2")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Win();

            CarAnimator.SetBool("StartCars2", true);

            StartCoroutine(LoadNext(2));
        }
        else if (TotalInput.text == "3")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Win();

            CarAnimator.Play("Cars3Animation");
            CarAnimator.enabled = true;

            StartCoroutine(LoadNext(3));
        }
        else
            this.gameObject.GetComponent<StoryScriptGeneric>()
                .Lose();
    }

    private void CarAnimationTransition(int cars)
    {
        if (cars == 2)
            CarAnimator.SetBool("TransitionToCars3", true);
        else if (cars == 3)
            CarAnimator.SetBool("TransitionToCars2", true);
    }

    IEnumerator LoadNext(int cars)
    {
        yield return new WaitForSeconds(4);

        CarAnimationTransition(cars);

        SceneManager.LoadScene("Scene8_5_2");
    }
}
