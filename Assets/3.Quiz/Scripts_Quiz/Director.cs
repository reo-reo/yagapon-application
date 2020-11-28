using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Constants{
	public const int LIMIT = 40;
}

public class Director : MonoBehaviour {

	public int scene = 0;
	public int num = 0;
	public Quiz.MaruBatu ans;
	public int isCorrect = -1;
	public int[] result = new int[5];

	public float points; //時間を管理する
	public int score;

	public GameObject que;
	public GameObject exp;
	public GameObject m;
	public GameObject b;
	public GameObject n;
	public GameObject message;
	public GameObject r;
	public GameObject rb;
	public GameObject number;
	public GameObject radar;

	[SerializeField]
	public DataBaseList dblist;
	public questionDataBase questionDataBase;

	// Use this for initialization
	void Start () {
		dblist.dbShuffle ();
		questionDataBase = dblist.getDataBaseList(0);
		questionDataBase.shuffle ();
		for (int i = 0; i < 5; i++) {
			result [i] = 0;
		}
	}

	void Update(){
		//question scene
		if (scene == 0) {
			exp.gameObject.SetActive (false);
			n.gameObject.SetActive (false);
			m.gameObject.SetActive (true);
			b.gameObject.SetActive (true);
			message.gameObject.SetActive (false);
			r.gameObject.SetActive (false);
			number.gameObject.SetActive (true);

			//時間に伴うポイントの加算
			points += Time.deltaTime;
		}

		//answer scene
		if (scene == 1) {
			
			if (num < 14) {
				n.gameObject.SetActive (true);
			} else {
				rb.gameObject.SetActive (true);
			}
			exp.gameObject.SetActive (true);
			m.gameObject.SetActive (false);
			b.gameObject.SetActive (false);
			message.gameObject.SetActive (true);
			r.gameObject.SetActive (false);
			number.gameObject.SetActive (true);


			if (isCorrect == 0) {
				message.GetComponent<Text> ().text = "正解だぽん!!";
			} else {
				message.GetComponent<Text> ().text = "残念、不正解だぽん...";
			}
		}
		//result scene
		if (scene == 2) {
			que.gameObject.SetActive (false);
			exp.gameObject.SetActive (false);
			n.gameObject.SetActive (false);
			m.gameObject.SetActive (false);
			b.gameObject.SetActive (false);
			message.gameObject.SetActive (false);
			r.gameObject.SetActive (true);
			radar.gameObject.SetActive (true);
			rb.gameObject.SetActive (false);
			number.gameObject.SetActive (false);
		}
	}
		

	public void goQuestionScene(){
		scene = 0;
	}

	public void goAnswerScene(){
		scene = 1;
	}

	public void goResultScene(){
		scene = 2;
		Debug.Log (points);
		Debug.Log (getScore (points));

	}

	public void reset(){
		dblist.dbShuffle ();
		questionDataBase = dblist.getDataBaseList(0);
		questionDataBase.shuffle ();
		scene = 0;
		num = 0;
		int i;
		for(i = 0; i < 5; i++){
			result[i] = 0;
		}
	}

	public void numIncrement(){
		num++;
	}

	public void answerMaru(){
		ans = (Quiz.MaruBatu)0;
		if (ans == questionDataBase.getQuizLists () [num].getAnswer ()) {
			result [0] += questionDataBase.getQuizLists () [num].getUn ();
			result [1] += questionDataBase.getQuizLists () [num].getSt ();
			result [2] += questionDataBase.getQuizLists () [num].getYf ();
			result [3] += questionDataBase.getQuizLists () [num].getYp ();
			result [4] += questionDataBase.getQuizLists () [num].getKo ();
			isCorrect = 0;
		} else {
			isCorrect = 1;
		}
	}

	public void answerBatu(){
		ans = (Quiz.MaruBatu)1;
		if (ans == questionDataBase.getQuizLists () [num].getAnswer ()) {
			result [0] += questionDataBase.getQuizLists () [num].getUn ();
			result [1] += questionDataBase.getQuizLists () [num].getSt ();
			result [2] += questionDataBase.getQuizLists () [num].getYf ();
			result [3] += questionDataBase.getQuizLists () [num].getYp ();
			result [4] += questionDataBase.getQuizLists () [num].getKo ();
			isCorrect = 0;
		} else {
			isCorrect = 1;
		}
	}
		
	public int getScore(float points){
		for(int i=0; i<5; i++){
			score += result[i];
		}
		if (points > Constants.LIMIT) {
			points = Constants.LIMIT;
		}
		score = score * 3 + (Constants.LIMIT - (int)points) * score / 30;
		return score;
	}
}