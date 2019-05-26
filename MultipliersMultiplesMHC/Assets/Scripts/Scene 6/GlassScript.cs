using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassScript : MonoBehaviour
{
    private GameObject Tick;

    private void FindTickObject()
    {
        Tick = GameObject.Find(this.gameObject.name + "Tick");
    }

    private void HideTick()
    {
        Tick.SetActive(false);
    }

    void Start()
    {
        FindTickObject();
        HideTick();
    }

    void OnMouseDown()
    {
        Tick.SetActive(true);
    }
}
