using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	AudioSource MainAudioSource;
	public AudioClip MainChoice;
	public AudioClip ToOthers;
	public AudioClip BackArrow;

	// Use this for initialization
	void Start () {
		MainAudioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MainChoicePlay(){
		MainAudioSource.clip = MainChoice;
		MainAudioSource.Play ();
	}

	public void ToOthersPlay(){
		MainAudioSource.clip = ToOthers;
		MainAudioSource.Play ();
	}

	public void BackArrowPlay(){
		MainAudioSource.clip = BackArrow;
		MainAudioSource.Play ();
	}


}
