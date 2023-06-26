using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveBg : MonoBehaviour
{
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
