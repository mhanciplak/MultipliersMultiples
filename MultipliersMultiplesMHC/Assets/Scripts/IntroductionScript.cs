using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroductionScript : MonoBehaviour {

	public InputField ifName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(){
		if (ifName.text != "")
			SceneManager.LoadScene ("FirstScene");
	}
}
