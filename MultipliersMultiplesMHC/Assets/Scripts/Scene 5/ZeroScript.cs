using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroScript : DragandDrop
{
    private GameObject Code;

    // Start is called before the first frame update
    void Start()
    {
        Code = GameObject.Find("Code");
        firstPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        drag = false;

        if (!inTrigger)
        {
            ReturnToOldPosition();
        }
        else if (this.gameObject.name == "Potato")
        {
            Code.GetComponent<UpdateNumber>().SetPotatoNumber();
        }
        else if (this.gameObject.name == "Cucumber")
        {
            Code.GetComponent<UpdateNumber>().SetCucumberNumber();
        }
        else if (this.gameObject.name == "Tomato")
        {
            Code.GetComponent<UpdateNumber>().SetTomatoNumber();
        }
    }
}
