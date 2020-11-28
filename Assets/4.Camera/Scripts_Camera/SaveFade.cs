using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveFade : MonoBehaviour {

	private float fadetime;
	private Image image;
	private float time;
	public float a;
	public int switchUpdate;

	void Start () {
		image = GetComponent<Image> ();
		switchUpdate = 0;
	}

	void Update () {
		if(switchUpdate == 1){
			time -= Time.deltaTime;
			a = time / fadetime;
			var color = image.color;
			color.a = a;
			image.color = color;
		}
	}

	public void FadeStart(){
		a = 200;
		fadetime = 1f;
		time = fadetime;
		var color = image.color;
		color.a = 200;
		switchUpdate = 1;
	}
}
