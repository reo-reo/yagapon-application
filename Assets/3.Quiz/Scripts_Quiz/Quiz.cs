using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[CreateAssetMenu(fileName = "Questions", menuName = "CreateQuestion")]
public class Quiz : ScriptableObject {
	
	public enum MaruBatu{
		Maru,
		Batu
	}

	[SerializeField]
	private string question;

	[SerializeField]
	private MaruBatu answer;

	[SerializeField]
	private string explanation;

	[SerializeField]
	private int un;

	[SerializeField]
	private int st;

	[SerializeField]
	private int yf;

	[SerializeField]
	private int yp;

	[SerializeField]
	private int ko;

	public string getQuestion(){
		return question;
	}

	public MaruBatu getAnswer(){
		return answer;
	}

	public string getExplanation(){
		return explanation;
	}

	public int getUn(){
		return un;
	}

	public int getSt(){
		return st;
	}

	public int getYf(){
		return yf;
	}

	public int getYp(){
		return yp;
	}

	public int getKo(){
		return ko;
	}
}
