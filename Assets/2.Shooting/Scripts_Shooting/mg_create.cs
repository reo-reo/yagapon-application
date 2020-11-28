using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mg_create : MonoBehaviour
{

    public GameObject enemyMissilePrefab;
    private int timeCount = 0;

    void Update()
    {

        timeCount += 1;

        if (timeCount % 60 == 0)
        {
            Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);
        }
    }

}
