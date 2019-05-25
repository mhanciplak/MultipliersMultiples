using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyutecTasimaScript : MonoBehaviour {

	// Use this for initialization
	Vector3 startpos;
	bool isinside=false;
	public GameObject buyutec;

	void Start () {
		startpos = buyutec.transform.position;

	}
	bool startdrag=false;
	void OnMouseDown()
	{

		Debug.Log ("Tıkladı");
		startdrag = true;
	}
	void OnMouseDrag()
	{
		if (startdrag) {
			Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			buyutec.transform.position = new Vector3 (newpos.x, newpos.y, 0);
		}
	}
	void OnMouseUp()
	{
		startdrag = false;
		buyutec.transform.position = startpos;
	}
}
