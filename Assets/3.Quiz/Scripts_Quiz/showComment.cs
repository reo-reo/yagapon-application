using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showComment : MonoBehaviour {

	public GameObject dir;
	// Use this for initialization
	void Start () {
		int score = dir.GetComponent<Director> ().score;
		string str;
		if (score < 60) {
			str = "気を落とさず、もう1年がんばるぽん!";
		} else if (score < 80) {
			str = "さすがだぽん!さらにがんばるぽん!";
		} else if (score < 100) {
			str = "すごいぽん、先生って呼んでいいぽんか?";
		} else {
			str = "まさかあなたが福沢先生だったぽんか!?";
		}
		this.GetComponent<Text> ().text = str;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
