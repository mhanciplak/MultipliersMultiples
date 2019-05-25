using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberScript : MonoBehaviour
{
    private static int firstBoxValue, secondBoxValue, thirdBoxValue;
    private int value;
    private bool isInCollider, drag;
    private string inBox;
    private Vector3 firstPosition;

    public GameObject TryAgain, Success;

    private void SetValue()
    {
        if (this.gameObject.tag == "Number2")
        {
            value = 2;
        }
        else
        {
            value = 3;
        }
    }

    private void SetBoxes()
    {
        firstBoxValue = secondBoxValue = thirdBoxValue = 0;
        inBox = "";
    }
    
    private void SetPosition()
    {
        firstPosition = this.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetBoxes();
        SetValue();
        SetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ReturnToOldPosition()
    {
        this.transform.position = firstPosition;
    }

    private void OnMouseDown()
    {
        drag = true;
    }

    private void PrintBoxValues()
    {
        Debug.Log("First Box : " + firstBoxValue);
        Debug.Log("Second Box : " + secondBoxValue);
        Debug.Log("Third Box : " + thirdBoxValue);
    }

    private void OnMouseDrag()
    {
        if (drag)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(mousePosition.x, mousePosition.y);
        }
    }

    private bool isFull()
    {
        if (this.inBox == "Col1" && firstBoxValue != 0)
        {
            return true;
        }
        else if (this.inBox == "Col2" && secondBoxValue != 0)
        {
            return true;
        }
        else if (this.inBox == "Col3" && thirdBoxValue != 0)
        {
            return true;
        }

        return false;
    }

    private void OnMouseUp()
    {
        drag = false;

        if (!isInCollider || isFull())
        {
            ReturnToOldPosition();
        }
        else
        {
            SetBoxValue();
        }

        PrintBoxValues();

        
    }

    private void CheckValues()
    {
        if (firstBoxValue + secondBoxValue + thirdBoxValue == 6)
        {
            StartCoroutine(StartPanel(Success));
        }
        else
        {
            StartCoroutine(StartPanel(TryAgain));
        }
    }

    IEnumerator StartPanel(GameObject obj)
    {
        yield return new WaitForSeconds(0.5F);

        Vector3 ilkscale1 = Vector3.zero;
        Vector3 sonscale1 = Vector3.one;

        float time1 = 0.4F;
        float timemax1 = time1;

        obj.SetActive(true);
        obj.transform.localScale = Vector3.zero;

        while (time1 > 0)
        {
            time1 -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
            obj.transform.localScale = Vector3.Lerp(ilkscale1, sonscale1, (timemax1 - time1) / timemax1);
        }
    }

    private void SetBoxValue()
    {
        if (inBox == "Col1")
        {
            firstBoxValue = this.value;
        }
        else if (inBox == "Col2")
        {
            secondBoxValue = this.value;
        }
        else if (inBox == "Col3")
        {
            thirdBoxValue = this.value;
        }
    }

    private void SetBoxesTrue(Collider2D col)
    {
        if (col.gameObject.name == "Col1")
        {
            inBox = "Col1";
        }
        else if (col.gameObject.name == "Col2")
        {
            inBox = "Col2";
        }
        else if (col.gameObject.name == "Col3")
        {
            inBox = "Col3";
        }
    }

    private void SetBoxesFalse(Collider2D col)
    {
        if (col.gameObject.name == "Col1")
        {
            inBox = "";
        }
        else if (col.gameObject.name == "Col2")
        {
            inBox = "";
        }
        else if (col.gameObject.name == "Col3")
        {
            inBox = "";
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isInCollider = true;

        SetBoxesTrue(col);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        isInCollider = false;

        SetBoxesFalse(col);
    }
}