using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseScript : MonoBehaviour
{
    public GameObject Tower, SuccessPanel, WrongPanel;
    public InputField HouseNumber, WindowNumber, TotalNumber;

    public void Check()
    {
        if (HouseNumber.text == "4" && WindowNumber.text == "2"
            && TotalNumber.text == "8")
        {
            StartCoroutine(WorkForSuccess());
        }
        else
        {
            WrongPanel.SetActive(true);
        }
    }

    IEnumerator WorkForSuccess()
    {
        Tower.SetActive(true);

        yield return new WaitForSeconds(1.5F);

        SuccessPanel.SetActive(true);
    }
}
