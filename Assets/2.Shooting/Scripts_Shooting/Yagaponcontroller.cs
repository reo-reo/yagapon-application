using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yagaponcontroller : MonoBehaviour
{

    public float moveSpeed = 0.2f;
    private Vector2 pos;
    private Vector3 playerPos;
    private Vector3 mousePos;
    //GameObject enemy;
    public GameObject gameOverPanel;
	public GameObject PointUI;
	public GameObject PointResult;

	void Update(){
        //float moveH = Input.GetAxis("Horizontal") * moveSpeed;
        //float moveV = Input.GetAxis("Vertical") * moveSpeed;
        //transform.Translate(moveH, moveV, 0.0f);

        playerControl();
        Clamp();
    }

    private void playerControl(){
        if (Input.GetMouseButtonDown(0)){
            playerPos = transform.position;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0)){
            Vector3 prePos = transform.position;
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mousePos;

            if (Input.touchSupported){
                diff = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) - mousePos;
            }

            diff.z = 0f;
            transform.position = playerPos + diff;
        }

        if (Input.GetMouseButtonUp(0)){
            playerPos = Vector3.zero;
            mousePos = Vector3.zero;
        }
    }

    void Clamp(){
        Vector2 pos = transform.position;
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);
        transform.position = pos;
    }

	private void OnCollisionEnter2D(Collision2D collision){
        gameObject.SetActive(false);
        //enemy.SetActive(false);
        gameOverPanel.SetActive(true);
		PointUI.GetComponent<TimerScript>().GameEnd();
		PointResult.GetComponent<PointResult> ().ResultPoint ();
	}
}