using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityDrag : MonoBehaviour {

	// Use this for initialization
	Vector3 startpos;
	bool isinside=false;
	GameObject matchingObject;
	public GameObject yanlisPanel;
	public GameObject dogruPanel;

	static int correctMatch = 0;

	void Start () {
		startpos = this.transform.position;

	}
	bool startdrag=false;
	void OnMouseDown()
	{

		startdrag = true;
	}
	void OnMouseDrag()
	{
		if (startdrag) {
			Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			this.transform.position = new Vector3 (newpos.x, newpos.y, 0);
		}
	}
	void OnMouseUp()
	{
		startdrag = false;
		if (!isinside) {
			this.transform.position = startpos;
		} else {
			this.transform.position = matchingObject.transform.position;
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		isinside = true;
		matchingObject = col.gameObject;
		if (col.gameObject.tag == gameObject.tag) {
			correctMatch++;
		}

	}

	void OnTriggerExit2D(Collider2D col){
		isinside = false;
	}

	public void kontrolEt(){
		if (correctMatch >= 4) {
			dogruPanel.SetActive (true);
		} else {
			yanlisPanel.SetActive (true);
			yanlisPanel.GetComponentInChildren<Text> ().text = (4 - correctMatch) + " tane yanlışın var.";
		}
	}
}
