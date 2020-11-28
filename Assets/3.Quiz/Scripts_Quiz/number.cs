using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number : MonoBehaviour {

	public GameObject dir;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		int n;
		n = dir.GetComponent<Director> ().num + 1;
		this.GetComponent<Text> ().text = "第" + n + "問";
	}
}
