using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopIn : MonoBehaviour {

	int counter;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (0.2f,0.2f,0.2f);
		counter = 40;
	}
	
	// Update is called once per frame
	void Update () {
		if(counter > 0){
			transform.localScale += new Vector3 (0.02f,0.02f,0.02f);
		}
		counter--;
	}
}
