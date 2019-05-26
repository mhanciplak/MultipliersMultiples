using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    protected bool drag, inTrigger;
    protected Vector3 firstPosition;

    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        drag = true;
    }

    protected void OnMouseDrag()
    {
        if (drag)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(mousePos.x, mousePos.y);
        }
    }

    void OnMouseUp()
    {
        drag = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        inTrigger = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        inTrigger = false;
    }

    protected void ReturnToOldPosition()
    {
        this.transform.position = firstPosition;
    }
}
