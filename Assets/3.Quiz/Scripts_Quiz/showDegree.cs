using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showDegree : MonoBehaviour {

	public GameObject dir;
	int score;
	string str;
	// Use this for initialization
	void Start () {
		score = dir.GetComponent<Director> ().score;

		if (score >= 100) {
			str = "福沢諭吉";
		} else if (score >= 95) {
			str = "名誉教授";
		} else if (score >= 90) {
			str = "教授";
		} else if (score >= 80) {
			str = "博士";
		} else if (score >= 70) {
			str = "修士";
		} else if (score >= 60) {
			str = "学士";
		} else {
			str = "留年";
		}

		this.GetComponent<Text> ().text = str;
	}

	// Update is called once per frame
	void Update () {
	}
}