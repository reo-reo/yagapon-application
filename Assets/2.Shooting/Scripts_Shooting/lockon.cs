using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockon : MonoBehaviour
{

    private GameObject target;

    void Start()
    {

    }

    void Update()
    {
        this.gameObject.transform.LookAt(target.transform.position);
    }
}