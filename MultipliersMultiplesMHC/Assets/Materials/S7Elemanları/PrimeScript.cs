using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeScript : MonoBehaviour
{
    public Vector3 mousePosition;

    private void OnMouseDown()
    {
        // this.gameObject.SetActive(false);

        // col.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    /* Old Update
    void Update()
    {
        mousePosition = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked.");
        }
    }
    */

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
            print("Found an object - distance: " + hit.distance);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("here");
                if (hit.transform.name == "kalbur")
                {
                    Debug.Log("My object is clicked by mouse");
                }
            }
        }
    }
}
