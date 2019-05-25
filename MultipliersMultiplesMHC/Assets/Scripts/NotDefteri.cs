using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDefteri : MonoBehaviour {

	public GameObject notDefteri;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void notDefteriniAc(){
		notDefteri.SetActive (!notDefteri.activeSelf);
	}
}
