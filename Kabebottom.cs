using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kabebottom : MonoBehaviour
{

    private float height;
    private float width;

    // Use this for initialization
    void Start()
    {
        Vector3 zero = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 rightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 1));

        height = rightTop.y - zero.y;
        width = rightTop.x - zero.x;

        transform.position = new Vector3(0, -height / 2, 0);
        transform.localScale = new Vector3(width, 0.01f, 0f);

    }
}
