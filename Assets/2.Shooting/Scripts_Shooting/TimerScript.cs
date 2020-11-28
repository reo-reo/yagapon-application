using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	//変数の定義
    public float points;
    private Text timerText;
	private int switchPoint;

	void Start () {
		//「変数の初期化」と「コンポーネントの取得」
		points = 0;
		switchPoint = 1;
        timerText = GetComponentInChildren<Text>();
	}
	
	void Update () {
		if(switchPoint == 1){
			//時間に伴うポイントの加算
	        points += Time.deltaTime;
			//ポイントに定数倍かけ、UITextで表示
			timerText.text = (points*100).ToString(".0");
		}
	}

	public void GameEnd(){
		switchPoint = 0;
	}
}
