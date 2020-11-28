using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sound_Shooting : MonoBehaviour {

	AudioSource MainAudioSource;
	public AudioClip ToHome;

	// Use this for initialization
	void Start () {
		MainAudioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToHomePlay(){
		MainAudioSource.clip = ToHome;
		MainAudioSource.Play ();
	}

}
