using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class WebCameraScript : MonoBehaviour {
	int width = Screen.width;
	int height = Screen.height;
	public int FPS = 30;
	public Color32[] color32;
	private WebCamTexture webcamtext;

//	int camera_switch;

	private IEnumerator Start(){
		if( WebCamTexture.devices.Length == 0 ){
			Debug.LogFormat( "カメラのデバイスが許可されてないので、許可してください。" );
			yield break;
		}

		yield return Application.RequestUserAuthorization( UserAuthorization.WebCam );
		if(!Application.HasUserAuthorization( UserAuthorization.WebCam)){
			Debug.LogFormat( "カメラを使うことが許可されてないので、許可してください。" );
			yield break;
		}
		transform.position = new Vector3 (0, height/1000f, 0);
		transform.localScale = new Vector3 (height/400f*3f, width/100f, 1f);
//		Debug.Log (height/400f*3f + ", " + width/100f);

		WebCamDevice[] devices = WebCamTexture.devices;
		webcamtext = new WebCamTexture (devices[1].name, width, height, FPS);

		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.mainTexture = webcamtext;
		webcamtext.Play ();

//		camera_switch = 0;

//		// とりあえず最初に取得されたデバイスを使ってテクスチャを作りますよ。
//		WebCamDevice userCameraDevice = WebCamTexture.devices[ 0 ];
//		m_webCamTexture = new WebCamTexture( userCameraDevice.name, m_width, m_height );
//
//		m_displayUI.texture = m_webCamTexture;
//
//		// さあ、撮影開始だ！
//		m_webCamTexture.Play();
	}

//	void Update () {
//		if(camera_switch == 1){
//			color32 = webcamtext.GetPixels32 ();
//			Texture2D texture = new Texture2D (webcamtext.width, webcamtext.height);
//			texture.SetPixels32 (color32);
//			texture.Apply ();
//			var bytes = texture.EncodeToPNG();
//			File.WriteAllBytes(Application.dataPath + "/camera.png", bytes);
//
//			int y = DateTime.Now.Year;
//			int M = DateTime.Now.Month;
//			int d = DateTime.Now.Day;
//			int h = DateTime.Now.Hour;
//			int m = DateTime.Now.Minute;
//			int s = DateTime.Now.Second;
//
//			string name = DateTime.Now.ToString ("yyyyMMddhhmmss");
//			string result = String.Concat("yaga", name, ".png");
//			ScreenCapture.CaptureScreenshot (result);
//			Debug.Log(Application.persistentDataPath);
//			Debug.Log(result);
//
//			camera_switch = 0;
//		}
//	}
//
//	public void Shot (){
//		camera_switch = 1;
//	} 
}
