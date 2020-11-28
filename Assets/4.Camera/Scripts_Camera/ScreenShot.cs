using System.Collections;
using UnityEngine;
using System.IO;
using System.Runtime.InteropServices;

public class ScreenShot : MonoBehaviour{

	private int switchP;
	public GameObject Button;
	public GameObject HomeB;
	public GameObject RightArrow;
	public GameObject LeftArrow;
	public GameObject SaveScene;

	[DllImport("__Internal")]
	private static extern void SaveToAlbum(string path);

	void Start(){
		switchP = 0;
	}

	IEnumerator SaveToCameraroll(string path){
		// ファイルが生成されるまで待つ
		while(true){
			if(File.Exists(path))
				break;            
			yield return null;
		}

		SaveToAlbum(path);
		Button.SetActive (true);
		HomeB.SetActive (true);
		RightArrow.SetActive(true);
		LeftArrow.SetActive(true);
		SaveScene.SetActive (true);
		SaveScene.GetComponent<SaveFade>().FadeStart();
//		FadeEnd ();
	}

	void Update(){
		if(switchP == 1){
#if UNITY_EDITOR
#else
			string filename = "test.png";
			string path = Application.persistentDataPath + "/" + filename;

			// 以前のスクリーンショットを削除する
			File.Delete(path);


			// スクリーンショットを撮影する
			float max = Mathf.Max(Screen.width, Screen.height);
			int scale = Mathf.RoundToInt( 2048 / max);
			ScreenCapture.CaptureScreenshot(filename, scale);

			// カメラロールに保存する
			StartCoroutine(SaveToCameraroll(path));
#endif
			switchP = 0;
		}

		if(SaveScene.GetComponent<SaveFade>().a < 1){
			SaveScene.GetComponent<SaveFade> ().switchUpdate = 0;
			SaveScene.SetActive (false);
		}
	}

	public void ShotP(){
		//ボタンなどを隠す
		Button.SetActive(false);
		HomeB.SetActive(false);
		RightArrow.SetActive(false);
		LeftArrow.SetActive(false);
		Invoke ("WaitDelta", 0.1f);
	}

	void WaitDelta(){
		switchP = 1;
	}
//
//	void FadeEnd(){
//		Invoke ("FadeEnd2", 1);
//	}
//
//	void FadeEnd2(){
//	}
}