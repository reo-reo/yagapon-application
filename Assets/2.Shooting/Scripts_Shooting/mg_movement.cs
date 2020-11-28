using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mg_movement : MonoBehaviour{



    // Update is called once per frame
    void Start(){
        transform.position = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        float maxY = transform.position.y; 
        transform.position = new Vector3(Random.Range(-maxY,maxY), transform.position.y,0);
    }

	void Update(){
//		transform.position -= new Vector3 (); 
	}

}


