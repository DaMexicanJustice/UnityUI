using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {

	public Slider ageSlider;
	public Text ageText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ageText.text = "" + ageSlider.value;
	}

	public void ExitApp() {
		Application.Quit ();
	}

}
