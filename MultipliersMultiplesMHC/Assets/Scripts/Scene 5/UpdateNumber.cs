using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateNumber : MonoBehaviour
{
    public Text PotatoNumber, CucumberNumber, TomatoNumber;
    public GameObject PotatoInput, CucumberInput, TomatoInput;

    public void SetPotatoNumber()
    {
        PotatoNumber.text = "0 Adet";
    }

    public void SetCucumberNumber()
    {
        CucumberInput.SetActive(true);
        CucumberNumber.text = "       Adet";
    }

    public void SetTomatoNumber()
    {
        TomatoInput.SetActive(true);
        TomatoNumber.text = "       Adet";
    }
}
