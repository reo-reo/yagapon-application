using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameChange : MonoBehaviour {
	public GameObject Frame1;
	public GameObject Frame2;
	public GameObject Frame3;
	private int CurrentFrame;

	// Use this for initialization
	void Start () {
		CurrentFrame = 1;
		Frame1.SetActive (true);
		Frame2.SetActive (false);
		Frame3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeFrameRight(){
		if(CurrentFrame >= 3){
			CurrentFrame = 0;
		}
		CurrentFrame++;
		ResetFrame ();
	}

	public void ChangeFrameLeft(){
		if(CurrentFrame <= 1){
			CurrentFrame = 4;
		}
		CurrentFrame--;
		ResetFrame ();
	}

	private void ResetFrame(){
		if(CurrentFrame == 1){
			Frame1.SetActive (true);
			Frame2.SetActive (false);
			Frame3.SetActive (false);
		}else if(CurrentFrame == 2){
			Frame1.SetActive (false);
			Frame2.SetActive (true);
			Frame3.SetActive (false);
		}else if(CurrentFrame == 3){
			Frame1.SetActive (false);
			Frame2.SetActive (false);
			Frame3.SetActive (true);
		}else{
			Debug.Log ("ResetFrame ERROR!");
		}
	}

}
