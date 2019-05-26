using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllNumbersScript : MonoBehaviour
{
    public static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
    public static int trueCount;

    private GameObject Code, KalburImage;
    private bool isPrime;
    private Sprite RedSprite, GreenSprite;

    private bool isInPrimes(int num)
    {
        foreach (var item in primes)
            if (num == item)
                return true;

        return false;
    }

    private void SetObjects()
    {
        Code = GameObject.Find("Code");
        KalburImage = GameObject.Find("KalburImage");
    }

    private void SetPrime()
    {
        if (isInPrimes(int.Parse(this.gameObject.name)))
            isPrime = true;
        else
            isPrime = false;
    }

    private void AssignSprites()
    {
        GreenSprite = GameObject.Find("Green").GetComponent<SpriteRenderer>().sprite;
        RedSprite = GameObject.Find("Red").GetComponent<SpriteRenderer>().sprite;
    }

    public void SetZero()
    {
        trueCount = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetObjects();
        SetPrime();
        AssignSprites();
    }

    private void SetSprite()
    {
        if (this.isPrime)
            this.GetComponent<SpriteRenderer>().sprite = GreenSprite;
        else
            this.GetComponent<SpriteRenderer>().sprite = RedSprite;
    }

    private void WorkForRights()
    {
        if (!this.isPrime)
            Code.GetComponent<RightsScript>().Decrease();
    }

    private void SetTrueCount()
    {
        if (this.isPrime) ++trueCount;
    }

    private void CheckTrueCount()
    {
        if (trueCount == 9)
        {
            KalburImage.SetActive(false);
            Code.GetComponent<RightsScript>().PlayKalburGif();
        }
    }

    void OnMouseDown()
    {
        SetSprite();

        SetTrueCount();
        CheckTrueCount();

        WorkForRights();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
