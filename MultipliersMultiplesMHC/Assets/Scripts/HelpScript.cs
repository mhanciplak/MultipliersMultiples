using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour {

	public GameObject helpPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void helpAcKapa(){
		helpPanel.SetActive (!helpPanel.activeSelf);
	}
}
