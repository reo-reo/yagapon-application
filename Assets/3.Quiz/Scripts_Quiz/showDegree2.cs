using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showDegree2 : MonoBehaviour {

	public GameObject dir;
	// Use this for initialization
	void Start () {
		int score = dir.GetComponent<Director> ().score;
		this.GetComponent<Text> ().text = score + "点のあなたは";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
