using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showExplanation : MonoBehaviour {
	
	public GameObject dir;

	[SerializeField]
	private questionDataBase questionDataBase;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		questionDataBase = dir.GetComponent<Director> ().questionDataBase;
		this.GetComponent<Text> ().text = questionDataBase.getQuizLists () [dir.GetComponent<Director> ().num].getExplanation ();
	}
}
