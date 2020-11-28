using UnityEngine;
using System.Collections;

public class sin_movement : MonoBehaviour
{
    public float yjiku; 
    float angle = 0;
    float range = 2f;
    float xspeed = 0.02f;
    float yspeed = 0.05f;

    // Use this for initialization
    void Start()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = transform.position;
        v.x += xspeed;
        v.y = Mathf.Sin(angle) * range -yjiku;
        angle += yspeed;
        transform.position = v;
    }
}
