using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showDegree3 : MonoBehaviour {

	public GameObject dir;
	// Use this for initialization
	void Start () {
		int score = dir.GetComponent<Director> ().score;
		string str;
		if (score < 60) {
			str = "だぽん...";
		} else if (score < 80) {
			str = "だぽん!";
		} else {
			str = "だぽん!!!";
		}
		this.GetComponent<Text> ().text = str;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
