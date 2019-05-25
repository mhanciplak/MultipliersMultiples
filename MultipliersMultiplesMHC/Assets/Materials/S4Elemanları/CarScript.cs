using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    public InputField DistanceInput;
    public GameObject SuccessPanel, TryAgain;
    private Animator CarAnimator;

    private int[] Numbers = { 8, 16, 24, 32, 48 };
    
    // Start is called before the first frame update
    void Start()
    {
        CarAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool Contains(int[] arr, int num)
    {
        foreach (var item in arr)
        {
            if (item == num)
            {
                return true;
            }
        }

        return false;
    }

    private void CheckInput(int inputNumber)
    {
        if (Contains(Numbers, inputNumber))
        {
            this.gameObject.GetComponent<StoryScript>().NextStory();
        }
        else
        {
            TryAgain.SetActive(true);
        }
    }
         

    public void Move()
    {
        int inputNumber = int.Parse(DistanceInput.text.Trim());

        CheckInput(inputNumber);

        CarAnimator.SetInteger("Parameter", int.Parse(DistanceInput.text.Trim()));

        if (CarAnimator.GetInteger("Parameter") == 48)
            StartCoroutine(ShowSuccessPanel());
    }

    IEnumerator ShowSuccessPanel()
    {
        yield return new WaitForSeconds(3);

        CarAnimator.SetInteger("Parameter", 99999);

        yield return new WaitForSeconds(2);

        SuccessPanel.SetActive(true);
    }
}
