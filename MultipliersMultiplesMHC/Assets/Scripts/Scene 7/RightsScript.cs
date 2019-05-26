using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RightsScript : MonoBehaviour
{
    public TextMeshProUGUI rightCount;
    public GameObject RestartPanel, SuccessPanel, KalburGif;
    private GameObject KalburImage;

    void Start()
    {
        KalburImage = GameObject.Find("KalburImage");
        rightCount.text = "3";
    }

    private bool isZero()
    {
        return rightCount.text == "0";
    }

    public void Decrease()
    {
        rightCount.text = (int.Parse(rightCount.text) - 1).ToString();

        if (isZero())
        {
            KalburImage.SetActive(false);
            RestartPanel.SetActive(true);
        }
    }

    public void PlayKalburGif()
    {
        KalburGif.SetActive(true);

        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(18);

        Debug.Log("Loaded.");
        SceneManager.LoadScene("Scene8_1_1");
    }

    public void ShowSuccessPanel()
    {
        SuccessPanel.SetActive(true);
    }
}
