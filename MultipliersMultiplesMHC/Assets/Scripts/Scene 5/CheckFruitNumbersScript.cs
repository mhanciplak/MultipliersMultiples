using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckFruitNumbersScript : MonoBehaviour
{
    public InputField CucumberInput, TomatoInput;

    private void SetStoryText(string text)
    {
        this.gameObject.GetComponent<StoryScriptGeneric>()
            .SetText(text);
    }

    private bool isActive(InputField inputField)
    {
        return inputField.isActiveAndEnabled;
    }

    public void Check()
    {
        if (!isActive(CucumberInput) || !isActive(TomatoInput))
            SetStoryText("Lütfen giriş yapmadan önce meyveleri kazana sürükle.");
        else if (CucumberInput.text == "0" && TomatoInput.text == "0")
            StartCoroutine(Success());
        else
            SetStoryText("Maalesef girdiğin meyve sayıları doğru değil.Tekrar denemelisin.");
    }

    IEnumerator Success()
    {
        SetStoryText("Tebrikler! Meyve sayılarının sıfır olduğunu buldun :)");

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Scene6");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
