using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	float waitingTime = 0.7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void SceneToShooting(){
		Invoke ("LoadShooting", waitingTime);
	}

	public void SceneToQuiz(){
		Invoke ("LoadQuiz", waitingTime);
	}

	public void SceneToCamera(){
		Invoke ("LoadCamera", waitingTime);
	}

	public void SceneToOthers(){
		Invoke ("LoadOther", waitingTime);
	}

	public void SceneToStart(){
		Invoke ("LoadStart", waitingTime);
	}

	//----------

	void LoadCamera(){
		SceneManager.LoadScene ("Camera");
	}

	void LoadShooting(){
		SceneManager.LoadScene ("Shooting");
	}

	void LoadQuiz(){
		SceneManager.LoadScene ("Quiz");
	}

	void LoadOther(){
		SceneManager.LoadScene ("OtherScene");
	}

	void LoadStart(){
		SceneManager.LoadScene ("StartScene");
	}
}
