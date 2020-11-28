using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackImageSwitch : MonoBehaviour {

	public GameObject SkyBack;
	public GameObject NightBack;

	int dateTime;

	// Use this for initialization
	void Start () {
		dateTime = 12;
	}
	
	// Update is called once per frame
	void Update () {
		dateTime = System.DateTime.Now.Hour;
		if(6<=dateTime && dateTime<=18){
			SkyBack.SetActive (true);
			NightBack.SetActive (false);
		}else{
			SkyBack.SetActive (false);
			NightBack.SetActive (true);
		}
	}
}
