using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointResult : MonoBehaviour {

	private Text TextContent;
	public GameObject PointObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ResultPoint(){
		TextContent = gameObject.GetComponent<Text> ();
		TextContent.text = "スコアは" + (PointObject.GetComponent<TimerScript>().points*100).ToString(".0") + "だぽん！";
	}
}
