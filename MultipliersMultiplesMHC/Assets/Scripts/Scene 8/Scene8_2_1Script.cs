﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene8_2_1Script : MonoBehaviour
{
    public InputField MemberCountInput, TotalCountInput;
    public Animator PencilsAnimator;

    void Start()
    {
        PencilsAnimator.enabled = false;
    }

    public void Enter()
    {
        if (MemberCountInput.text == "3" && TotalCountInput.text == "4")
        {
            PencilsAnimator.Play("PencilsAnimation");
            PencilsAnimator.enabled = true;

            this.gameObject.GetComponent<StoryScriptGeneric>().SetText("Tebrikler. Bütün sayıları doğru bildin. :)");
        }
    }
}