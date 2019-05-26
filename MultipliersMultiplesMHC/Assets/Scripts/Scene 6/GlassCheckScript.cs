using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassCheckScript : MonoBehaviour
{
    public GameObject FirstTick, SecondTick, ThirdTick, FourthTick;
    public GameObject FiveObject;
    public Animator KingAnimator;
    private bool isPlayed;

    void Start()
    {
        FiveObject.SetActive(false);
        isPlayed = false;
        KingAnimator.enabled = false;
    }

    public void ResetTicks()
    {
        FirstTick.SetActive(false);
        SecondTick.SetActive(false);
        ThirdTick.SetActive(false);
        FourthTick.SetActive(false);
    }

    public void Check()
    {
        if (FirstTick.activeSelf && !SecondTick.activeSelf
            && !ThirdTick.activeSelf && FourthTick.activeSelf && !isPlayed)
        {
            FiveObject.SetActive(true);
            KingAnimator.Play("KingAnimation");
            KingAnimator.enabled = true;
            isPlayed = true;

            this.gameObject.GetComponent<StoryScriptGeneric>().SetText("Tebrikler! Bütün bardakları doğru işaretledin.");
        }
        else if (isPlayed)
        {
            this.gameObject.GetComponent<StoryScriptGeneric>().SetText("Bardakları zaten doğru işaretledin.");
        }
        else
        {
            this.gameObject.GetComponent<StoryScriptGeneric>().SetText("Maalesef işaretlediğin bardaklar doğru değil.");
        }
    }
}
