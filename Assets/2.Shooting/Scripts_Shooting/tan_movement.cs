using UnityEngine;
using System.Collections;

public class tan_movement : MonoBehaviour
{
    public float xjiku;
    float angle = 30;
    float speed = 0.005f;

    // Use this for initialization
    void Start()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = transform.position;
        v.x += 0.01f;
        v.y = Mathf.Tan(angle);
        angle += speed;
        transform.position = v;
    }
}
