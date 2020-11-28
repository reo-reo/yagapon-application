using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchedEnemy : MonoBehaviour
{
    public float missileSpeed;
    GameObject yagapon;
    GameObject enemy;
    GameObject gameOverPanel;

    // Use this for initialization
    void Start()
    {
        this.yagapon = GameObject.Find("yagapon");
        this.enemy = GameObject.Find("Enemy");
        this.gameOverPanel = GameObject.Find("Gameover_Panel");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f * missileSpeed, 0);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.yagapon.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.25f;
        float r2 = 0.5f;

        GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("Enemyshot");

        if (d < r1 + r2)
        {
            yagapon.SetActive(false);
            enemy.SetActive(false);
            gameOverPanel.SetActive(true);


            foreach (GameObject obj in tagobjs)
            {
                Destroy(obj);
            }

        }

    }





}
