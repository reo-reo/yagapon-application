using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour {

	public GameObject dir;
	// Use this for initialization
	void Start () {
		string str = dir.GetComponent<Director> ().score.ToString(); 
		this.GetComponent<Text> ().text = str;
	}

	// Update is called once per frame
	void Update () {
	}
}
