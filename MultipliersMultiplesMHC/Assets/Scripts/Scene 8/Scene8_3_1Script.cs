using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene8_3_1Script : MonoBehaviour
{
    public InputField FirstInput, SecondInput;

    private void SetText(string text)
    {
        this.gameObject.GetComponent<StoryScriptGeneric>().SetText(text);
    }

    public void Check()
    {
        if (FirstInput.text == "2" && SecondInput.text == "2")
        {
            SetText("Tebrikler. Grup sayılarını doğru girdin.");

            StartCoroutine(LoadNextScene());
        }
        else
            SetText("Maalesef, grup sayıların doğru değil. Tekrar denemelisin.");
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Scene8_3_2");
    }
}
