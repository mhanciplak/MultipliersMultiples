using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuyutecScript : MonoBehaviour {

	public Text konusmaText;
	public string[] nesneler;
	public GameObject btnIleri;
	List<string> lstFoundItems;
	int i = 4;

	// Use this for initialization
	void Start () {
		lstFoundItems = new List<string> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		konusmaText.text = nesneler [int.Parse (col.gameObject.tag)];
		if (!lstFoundItems.Contains(col.gameObject.tag))
			lstFoundItems.Add (col.gameObject.tag);
		if (lstFoundItems.Count == 4) {
			btnIleri.SetActive (true);
		}
	}

	public void ileriButon(){
		if (i < nesneler.Length) {
			konusmaText.text = nesneler [i];
			i++;
		} else
			SceneManager.LoadScene ("Event2");
	}
}
