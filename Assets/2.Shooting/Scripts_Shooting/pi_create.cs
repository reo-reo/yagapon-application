using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pi_create : MonoBehaviour
{

    public GameObject enemyMissilePrefab;
    private int timeCount = 0;

    //float speed = 0.1f;
    float angle = 0f;
    Vector3 pos;


    // Use this for initialization
    void Start(){
        //pos = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
        pos = new Vector3(0,0,0);
        gameObject.transform.position = pos;
    }

    // Update is called once per frame
    void Update(){
            pos.x = Mathf.Cos(Time.deltaTime * 2f) * 10f;
            pos.y = Mathf.Sin(Time.deltaTime * 2f) * 10f;
            gameObject.transform.position = pos;

            //Vector3 shotVec = new Vector3(Mathf.Cos(i * Mathf.PI / 180f), Mathf.Sin(i * Mathf.PI / 180f), 0f) * speed;

        //angle += 1f;
    }

//    Vector3 pos = Vector3.zero; //中心を決めます。今回は(0,0,0)
//    float speed = 2.0f;

//    //範囲を指定してあげると大きな円、小さな円を実装できます。
//    pos.x += Mathf.Sin(Time.time* speed) * 4f; 
//    pos.y += Mathf.Cos(Time.time* speed) * 2f;
//    target.position = pos;

    //void Update()
    //{

    //    timeCount += 1;

    //    if (timeCount % 60 == 0)
    //    {
    //        Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);
    //    }
    //}

}
