using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    public InputField DistanceInput;
    public GameObject SuccessPanel;
    private Animator CarAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        CarAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
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
