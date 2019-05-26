using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PartitionScript : MonoBehaviour
{
    public Animator KidsAnimator;
    public InputField GroupInput;
    public GameObject TryAgainPanel;

    // Start is called before the first frame update
    void Start()
    {
        KidsAnimator.enabled = false;
    }

    public void CheckInput()
    {
        if (GroupInput.text == "2")
        {

        }
        else
        {
            TryAgainPanel.SetActive(true);
        }
    }

    IEnumerator SuccessCoroutine()
    {
        yield return new WaitForSeconds(1);

        KidsAnimator.Play("KidsAnimation");
        KidsAnimator.enabled = true;

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Scene8_1_2");
    }
}
