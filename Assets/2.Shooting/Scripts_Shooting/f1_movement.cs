using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f1_movement : MonoBehaviour{

    // Update is called once per frame
    void Update(){
        transform.Translate(0, -0.1f * 1, 0);
    }
}

